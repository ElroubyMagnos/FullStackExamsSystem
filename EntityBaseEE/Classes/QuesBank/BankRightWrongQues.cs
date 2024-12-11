using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBaseEE.Classes.Bank;

public class BankRightWrongQues
{
    public int ID { get; set; }
    public string Title { get; set; }
    public bool RightAnswer { get; set; }
    public int SubjectID { get; set; }
    public int OwnerID { get; set; }
}
