using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBaseEE.Classes
{
    public class AnswerOfEssay
    {
        public int ID { get; set; }
        public bool ismarked { get; set; }
        public int quesid { get; set; }
        public string studentname { get; set; }
        public string answer { get; set; }
        public int Points { get; set; }
    }
}
