using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBaseEE.Classes.Bank;

public class BankChooseQues
{
    public int ID { get; set; }
    public string Title { get; set; }
    public int RightAnswer { get; set; }
    public string FirstAnswer { get; set; }
    public string SecondAnswer { get; set; }
    public string ThirdAnswer { get; set; }
    public string FourthAnswer { get; set; }
    public int SubjectID { get; set; } 
    public int OwnerID { get; set; }
}
