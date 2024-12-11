using System.ComponentModel.DataAnnotations;

namespace ESiteCore.Server.Classes
{
    public class TypeOfLearn
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string NameOf { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
