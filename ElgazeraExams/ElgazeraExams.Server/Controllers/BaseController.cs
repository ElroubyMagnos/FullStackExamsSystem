using EntityBaseEE.Classes;
using EntityBaseEE.Migrations;
using ESiteCore.Server;
using ESiteCore.Server.Classes;
using ESiteCore.Server.SpeedUseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElgazeraExams.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {
        private readonly ILogger<BaseController> _logger;

        public BaseController(ILogger<BaseController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ExamSafety/{spec}/{goy}/{studentid}")]
        public async Task<bool> ExamSafety(int spec, int goy, int studentid)
        {
            var g = new gzera();

            var student = await g.Students.FirstOrDefaultAsync(x => x.UniqueNumber == studentid);

            if (student == null)
                return false;

            if (student.GradeNumber != goy)
            {
                return false;
            }

            if (student.Speciality != spec)
            {
                return false;
            }

            return true;
        }

        [HttpGet("CheckExamTime/{examid}")]
        public async Task<bool> CheckExamTime(int examid)
        {
            var g = new gzera();

            var SelectedExam = await g.Exams.FirstOrDefaultAsync(x => x.ID == examid);

            if (SelectedExam == null)
                return false;

            if (SelectedExam.OpenTime == null || SelectedExam.CloseTime == null)
                return false;
            
            return SelectedExam.OpenTime <= DateTime.Now && SelectedExam.CloseTime >= DateTime.Now;
        }

        [HttpPost("GetAnswersAfterExam")]
        public async Task<int> GetAnswersAfterExam([FromBody] List<Answer> Answers)
        {
            var g = new gzera();
            
            var FullMarks = Answers.Count();
            var StudentMarks = 0;
            var StudentUniqueID = 0;
            var currentexamid = 0;

            foreach (Answer answ in Answers)
            {
                if (answ.ischoose)
                {
                    var AnswerSource = await g.ChooseQuestions.FirstOrDefaultAsync(x => x.ID == answ.quesid);

                    currentexamid = AnswerSource.ExamID;
                    StudentUniqueID = answ.student;

                    switch (AnswerSource.RightAnswer)
                    {
                        case 0:
                        if (answ.selectedanswer == AnswerSource.FirstAnswer)
                        {
                            StudentMarks++;
                        }
                        break;

                        case 1:
                        if (answ.selectedanswer == AnswerSource.SecondAnswer)
                        {
                            StudentMarks++;
                        }
                        break;

                        case 2:
                        if (answ.selectedanswer == AnswerSource.ThirdAnswer)
                        {
                            StudentMarks++;
                        }
                        break;

                        case 3:
                        if (answ.selectedanswer == AnswerSource.FourthAnswer)
                        {
                            StudentMarks++;
                        }
                        break;
                    }
                }
                else
                {
                    var AnswerSource = await g.RightWrongQuestions.FirstOrDefaultAsync(x => x.ID == answ.quesid);

                    currentexamid = AnswerSource.ExamID;
                    StudentUniqueID = answ.student;

                    if (answ.selectedanswer == "Right" && AnswerSource.RightAnswer)
                    {
                        StudentMarks++;
                    }
                    else if (answ.selectedanswer == "Wrong" && !AnswerSource.RightAnswer)
                    {
                        StudentMarks++;
                    }
                }
            }

            var CurrentProgress = await g.ExamProgresses.FirstOrDefaultAsync(x => x.ExamID == currentexamid && x.StudentID == StudentUniqueID);

            if (CurrentProgress != null)
            {
                return 0;
            }  

            await g.ExamProgresses.AddAsync(new ExamProgress()
            {
                ExamID = currentexamid,
                GottenMarks = StudentMarks,
                TotalMarks = FullMarks,
                StudentID = StudentUniqueID
            });

            await g.SaveChangesAsync();

            return StudentMarks;
        }

        [HttpGet("GetChooseQuestionsByExamID/{examid}")]
        public async Task<List<ChooseQues>> GetChooseQuestionsByExamID(int examid)
        {
            var g = new gzera();
            var Exam = await g.Exams.FirstOrDefaultAsync(x => x.ID == examid);
            
            var x = Extensions.Shuffle(await g.ChooseQuestions.Where(x => x.ExamID == examid).ToListAsync());
            
            if (Exam.Shuffle)
                return Extensions.Shuffle(await g.ChooseQuestions.Where(x => x.ExamID == examid).ToListAsync());
            else return await g.ChooseQuestions.Where(x => x.ExamID == examid).ToListAsync();
        }

        [HttpGet("GetRightWrongQuestionsByExamID/{examid}")]
        public async Task<List<RightWrongQues>> GetRightWrongQuestionsByExamID(int examid)
        {
            var g = new gzera();
            var Exam = await g.Exams.FirstOrDefaultAsync(x => x.ID == examid);

            if (Exam.Shuffle) return Extensions.Shuffle(await g.RightWrongQuestions.Where(x => x.ExamID == examid).ToListAsync());
            else return await g.RightWrongQuestions.Where(x => x.ExamID == examid).ToListAsync();
        }

        [HttpGet("GetExamByID/{spec}/{goy}/{examid}/{studentid}")]
        public async Task<ExamMain> GetExamByID(int spec, int goy, int examid, int studentid)
        {
            var g = new gzera();

            var CurrentProgress = await g.ExamProgresses.FirstOrDefaultAsync(x => x.ExamID == examid && x.StudentID == studentid);

            if (CurrentProgress != null)
                return null;

            return await g.Exams.FirstOrDefaultAsync(x => x.Specality == spec && x.YearNumber == goy
            && x.ID == examid);
        }

        [HttpGet("GetExamCover/{spec}/{goy}")]
        public async Task<List<ExamMain>> GetExamCover(int spec, int goy)
        {
            var g = new gzera();

            var selectedexam = await g.Exams.Where(x => x.Specality == spec && x.YearNumber == goy).ToListAsync();

            return selectedexam;
        }

        [HttpGet("GetGrades/{specality}")]
        public async Task<List<GradeOfYear>> GetGrades(int specality)
        {
            var g = new gzera();

            var selected = await g.GradeOfYears.Where(x => x.TypeOfLearnID == specality).ToListAsync();

            return selected;
        }

        [HttpPost("CheckSignedIn")]
        public async Task<bool> CheckSignedIn([FromBody] LoginInfo li)
        {
            var g = new gzera();
            
            var Selected = await g.Students.FirstOrDefaultAsync(x => x.Name == li.Name && x.UniqueNumber == li.UniqueNumber);
            
            if (Selected != null)
            {
                if (g.SiteSettings.Count() == 0)
                    return false;

                return Selected.ExpireDate < (await g.SiteSettings.FirstOrDefaultAsync()).StudentAccountExpirationDate;
            }
            else return false;
        }   

        [HttpGet("GetYearOfGrade/{typeoflearn}")]
        public async Task<List<GradeOfYear>> GetYearOfGrade(int typeoflearn)
        {
            gzera g = new gzera();

            return await g.GradeOfYears.Where(x => x.TypeOfLearnID == typeoflearn).ToListAsync();
        }

        [HttpGet("GetSpecality")]
        public async Task<List<TypeOfLearn>> GetSpecality()
        {
            gzera g = new gzera();

            return await g.TypeOfLearns.ToListAsync();
        }

        [HttpPost("SignUpStudent")]
        public async Task<bool> SignUpStudent([FromBody] Student studentdata)
        {
            var g = new gzera();

            var CheckIt = await g.Students
            .FirstOrDefaultAsync(x => x.UniqueNumber == studentdata.UniqueNumber);

            if (CheckIt != null)
                return false;
            else
            {
                await g.Students.AddAsync(studentdata);

                await g.SaveChangesAsync();
                return true;
            }
        }
    }
}
