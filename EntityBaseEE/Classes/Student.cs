using System.ComponentModel.DataAnnotations;

namespace ESiteCore.Server.Classes
{
    public class Student
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        public int UniqueNumber { get; set; }
        public int GradeNumber { get; set; }
        public int Speciality { get; set; }
        public int Group { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
