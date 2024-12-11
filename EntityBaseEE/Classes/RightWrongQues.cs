using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBaseEE.Classes
{
    public class RightWrongQues
    {
        public int ID { get; set; }
        public int ExamID { get; set; }
        public int Points { get; set; }
        public string Title { get; set; }
        public bool RightAnswer { get; set; }
    }
}
