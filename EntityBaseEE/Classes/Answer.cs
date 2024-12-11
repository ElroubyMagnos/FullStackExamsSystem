using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBaseEE.Classes
{
    public class Answer
    {
        public int ID { get; set; }
        public bool ischoose { get; set; }
        public int quesid { get; set; }
        public string selectedanswer { get; set; }
        public int student { get; set; }
        public bool Right { get; set; }
    }
}
