using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbsEX3
{
    class Student : Person
    {
        protected string subject;

        public Student()
        {
            
        }

        public Student( string n, string p, string e, string x) : base (n, p, e)
        {
            this.subject = x;
        }
        public void input1()
        {
            Console.Write("Enter Subject: ");
            subject = Console.ReadLine();
            
        }
        public override String ToString()
        {
            return ("INFO Student:\n - Name: " +Pname + ", Phone: " + Pphone + ", Email: " + PEmail+ ", subjec: " +subject);
        }



    }
    
    
}
