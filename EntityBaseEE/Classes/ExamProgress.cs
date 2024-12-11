using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBaseEE.Classes
{
    public class ExamProgress
    {
        public int ID { get; set; }
        public int ExamID { get; set; }
        public int TotalMarks { get; set; }
        public int GottenMarks { get; set; }
        public int StudentID { get; set; }
        public bool Corrected { get; set; }
    }
}
