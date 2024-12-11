using ESiteCore.Server.Classes;
using EntityBaseEE.Classes;
using Microsoft.EntityFrameworkCore;
using EntityBaseEE.Classes.Bank;

namespace ESiteCore.Server
{
    public class gzera : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlServer("Server=localhost;Database=elgazera;Trusted_Connection=True;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=elgazera;User Id=sa;Password=Magnos0182163958;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Data Source=192.168.1.150;Initial Catalog=elgazera;User Id=sa;Password=Magnos0182163958;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Data Source=elrouby.ddns.net;Initial Catalog=elgazera;User Id=sa;Password=Magnos0182163958;TrustServerCertificate=True");
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=elgazera;User Id=sa;Password=123;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Server=192.168.1.100;Initial Catalog=gzerains;User ID=sa;Password=123;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
        }
        public DbSet<EssayQues> EssayQuestions { get; set; }
        public DbSet<TypeOfLearn> TypeOfLearns { get; set; }
        public DbSet<GradeOfYear> GradeOfYears { get; set; }
        public DbSet<YearWithNumber> YearWithNumbers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<GroupSign> GroupSigns { get; set; }
        public DbSet<UserCont> UserConts { get; set; }
        public DbSet<SiteSettings> SiteSettings { get; set; }
        public DbSet<ExamMain> Exams { get; set; }
        public DbSet<ExamProgress> ExamProgresses { get; set; }
        public DbSet<ChooseQues> ChooseQuestions { get; set; }
        public DbSet<RightWrongQues> RightWrongQuestions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AnswerOfEssay> AnswersOfEssay { get; set; }
        public DbSet<BankChooseQues> ChooseBank { get; set; }
        public DbSet<BankRightWrongQues> RightWrongBank { get; set; }
        public DbSet<BankEssayQues> EssayBank { get; set; }
    }       
}
