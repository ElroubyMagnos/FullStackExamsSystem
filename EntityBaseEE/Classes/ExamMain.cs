using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBaseEE.Classes
{
    public class ExamMain
    {
        public int ID { get; set; }
        public int Specality { get; set; }
        public int YearNumber { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int Subject { get; set; }
        public byte[] CoverImage { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public bool Shuffle { get; set; }
        public string DoctorUserName { get; set; }
    }
}
