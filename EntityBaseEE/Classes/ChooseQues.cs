using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBaseEE.Classes
{
    public class ChooseQues
    {
        public int ID { get; set; }
        public int ExamID { get; set; }
        public string Title { get; set; }
        public int RightAnswer { get; set; }
        public int Points { get; set; }
        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdAnswer { get; set; }
        public string FourthAnswer { get; set; }
    }
}
