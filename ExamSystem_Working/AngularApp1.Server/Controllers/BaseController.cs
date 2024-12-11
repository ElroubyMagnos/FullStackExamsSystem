using System.Drawing.Imaging;
using AngularApp1.Server;
using AngularApp1.Server.QueryClasses;
using ElgazeraExams.Server;
using ElroubyCaptcha;
using EntityBaseEE.Classes;
using EntityBaseEE.Migrations;
using ESiteCore.Server;
using ESiteCore.Server.Classes;
using ESiteCore.Server.SpeedUseClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Online_Buy_Plus.Controllers;

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
    public async Task<bool> ExamSafety(int spec, int goy, string studentid)
    {
        var g = new gzera();

        var student = await g.Students.FirstOrDefaultAsync(x => x.Password == studentid);

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

    [HttpGet("GetCloseDate/{examid}")]
    public async Task<DateTime> GetCloseDate(int examid)
    {
        var g = new gzera();

        var SelectedExam = await g.Exams.FirstOrDefaultAsync(x => x.ID == examid);

        return SelectedExam.CloseTime;
    }

    [HttpPost("GetEssayAfterExam")]    
    public async Task GetEssayAfterExam([FromBody] List<AnswerOfEssay> EssayAnswers)
    {
        var g = new gzera();

        await g.AnswersOfEssay.AddRangeAsync(EssayAnswers);

        await g.SaveChangesAsync();
    }

    [HttpGet("CheckExamCorrected/{examid}/{student}")]
    public async Task<bool> CheckExamCorrected(int examid, string student)
    {
        var g = new gzera();
        var Selected = await g.ExamProgresses
        .FirstOrDefaultAsync(x => x.ExamID == examid && x.StudentID == g.Students.FirstOrDefault(y => y.Name == student).ID);

        if (Selected == null)
        {
            return false;
        }
        else if (Selected.Corrected == null)
        {
            return false;
        }
        else
        {
            return Selected.Corrected;
        }
    }


    [HttpPost("GetAnswersAfterExam/{examid}/{NameOfStudent}")]
    public async Task GetAnswersAfterExam([FromBody] List<Answer> Answers, int examid, string NameOfStudent)
    {
        var g = new gzera();

        var Score = 0;
        var AllScore = Answers.Count();

        foreach (var answer in Answers)
        {
            if (answer.ischoose)
            {
                var GetSource = await g.ChooseQuestions
                .FirstOrDefaultAsync(x => x.ID == answer.quesid);

                answer.Right = false;

                switch(GetSource.RightAnswer)
                {
                    case 0:
                        answer.Right = GetSource.FirstAnswer == answer.selectedanswer;
                    break;
                    case 1:
                        answer.Right = GetSource.SecondAnswer == answer.selectedanswer;
                    break;
                    case 2:
                        answer.Right = GetSource.ThirdAnswer == answer.selectedanswer;
                    break;
                    case 3:
                        answer.Right = GetSource.FourthAnswer == answer.selectedanswer;
                    break;
                }

                g.Answers.Update(answer);

                await g.SaveChangesAsync();
            }
            else
            {
                var GetSource = await g.RightWrongQuestions
                .FirstOrDefaultAsync(x => x.ID == answer.quesid);

                answer.Right = false;

                if (answer.selectedanswer == "Right" && GetSource.RightAnswer)
                {
                    answer.Right = true;
                }
                else if (answer.selectedanswer == "Wrong" && !GetSource.RightAnswer)
                {
                    answer.Right = true;
                }

                g.Answers.Update(answer);

                await g.SaveChangesAsync();
            }

            if (answer.Right)
                Score++;
        }

        await g.SaveChangesAsync();
        
        var SelectedStudent = await g.Students.FirstOrDefaultAsync(x => x.Name == NameOfStudent);

        if ((await g.ExamProgresses.FirstOrDefaultAsync(x => x.ExamID == examid && x.StudentID == SelectedStudent.ID)) == null)
        {
            var EP = new ExamProgress()
            {
                ExamID = examid,
                GottenMarks = 0,
                TotalMarks = 0,
                StudentID = SelectedStudent.ID
            };

            EP.GottenMarks += Score;
            EP.TotalMarks += AllScore;

            await g.ExamProgresses.AddAsync(EP);

            await g.SaveChangesAsync();
        }

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

    [HttpGet("GetEssayQuestionsByExamID/{examid}")]
    public async Task<List<EssayQues>> GetEssayQuestionsByExamID(int examid)
    {
        var g = new gzera();
        var Exam = await g.Exams.FirstOrDefaultAsync(x => x.ID == examid);

        if (Exam.Shuffle) return Extensions.Shuffle(await g.EssayQuestions.Where(x => x.ExamID == examid).ToListAsync());
        else return await g.EssayQuestions.Where(x => x.ExamID == examid).ToListAsync();
    }

    [HttpGet("GetExamByID/{spec}/{goy}/{examid}/{NameofStudent}")]
    public async Task<ExamMain> GetExamByID(int spec, int goy, int examid, string NameofStudent)
    {
        var g = new gzera();

        var Student = await g.Students.FirstOrDefaultAsync(x => x.Name == NameofStudent);

        var CurrentProgress = await g.ExamProgresses.FirstOrDefaultAsync(x => x.ExamID == examid && x.StudentID == Student.ID);

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

    [HttpPost("CheckCredentials")]
    public async Task<bool> CheckCredentials([FromBody] UserLogin UL)
    {
        var g = new gzera();

        return (await g.Students.FirstOrDefaultAsync(x => x.Name == UL.Name && x.Password == UL.Password)) != null;
    }

    [HttpGet("CheckSignedIn/{Name}/{Password}")]
    public async Task<bool> CheckSignedIn(string Name, string Password)
    {
        if (Name == "null" || Password == "null")
        {
            return false;
        }
        
        if (Name == null || Password == null)
        {
            return false;
        }
        var g = new gzera();

        var Selected = await g.Students.FirstOrDefaultAsync(x => x.Name == Name && x.Password == Password);

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

    [HttpGet("GetResultForStudent/{examid}/{NameOfStudent}")]
    public async Task<ExamProgress> GetResultForStudent(int examid, string NameOfStudent)
    {
        var g = new gzera();
        var SelectedStudent = await g.Students.FirstOrDefaultAsync(x => x.Name == NameOfStudent);

        return await g.ExamProgresses
        .FirstOrDefaultAsync(x => x.ExamID == examid && x.StudentID == SelectedStudent.ID);
    }
    
    [HttpGet("GetStudentByUnique/{ID}")]
    public async Task<string> GetStudentByUnique(string ID)
    {
        var g = new gzera();

        return (await g.Students.FirstOrDefaultAsync(x => x.Password == ID)).Name;
    }

    [HttpGet("GetNameOfExamByID/{ID}")]
    public async Task<string> GetNameOfExamByID(int ID)
    {
        var g = new gzera();

        return (await g.Exams.FirstOrDefaultAsync(x => x.ID == ID)).Title;
    }

    [HttpGet("GenerateCaptcha")]
    public async Task<CaptchaFinal> GenerateCaptcha()
    {
        ReCaptcha ec = new ReCaptcha();
        var Generated = ec.Generate();

        var Final = new CaptchaFinal();
        var Image = Generated.I;
        var ms = new MemoryStream();

        Image.Save(ms, ImageFormat.Jpeg);

        Final.I = ms.ToArray();
        Final.Text = Generated.Text;
        return Final;
    }

    [HttpGet("TimeLeftForExam/{examid}")]
    public async Task<string> TimeLeftForExam(int examid)
    {
        var g = new gzera();

        var examdate = await g.Exams.FirstOrDefaultAsync(x => x.ID == examid);

        var timespan = (examdate.CloseTime - DateTime.Now).ToString();

        return timespan;
    }
}
