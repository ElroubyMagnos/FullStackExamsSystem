using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESiteCore.Server.Classes
{
    public class GradeOfYear
    {
        public int ID { get; set; }
        public int TypeOfLearnID { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public int IDOfGrade { get; set; }
    }
}
