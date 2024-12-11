using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBaseEE.Classes
{
    public class UserCont
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        [MaxLength(200)]
        public bool CanCreateAccounts { get; set; } = false;
        public bool CanDeleteAllExams { get; set; } = false;
        public bool CanSignIn { get; set; } = false;
        public bool CanEnterSettings { get; set; } = false;
        public bool CanEnterCore { get; set; } = false;
        public bool CanEnterStudentWindow { get; set; } = false;
        public bool CanEnterExamsWindow { get; set; } = false;
        public bool CanEditAllStudentsData { get; set; } = false;
        public bool CanEnterQuestionsBank { get; set; } = false;
        public bool IsAccepted { get; set; } = false;
    }
}
