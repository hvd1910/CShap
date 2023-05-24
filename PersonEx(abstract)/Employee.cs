using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EbsEX3
{
        abstract class Employee : Person
    {
        protected string part;
        protected int salary;
        protected DateTime DateHired;
        protected int Day;

        protected Employee()
        {
        }

        public Employee (string n, string p, string e, string p2, int s, DateTime dt) :base(n, p, e)
        {
            this.part = p2;
            this.salary = s;
            this.DateHired = dt;
        }

        public void input2() {
            
            int day, month, year;
            Console.Write("Enter Part: ");
            part = Console.ReadLine();
            Console.Write("Enter Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year: ");
            year = Convert.ToInt32(Console.ReadLine());

            DateHired  = new DateTime(year, month, day);
            DateTime dtnow = DateTime.Now;
            TimeSpan a = dtnow - DateHired;
            Day = a.Days;
        }

        public override String ToString()
        {
            return ("INFO Student:\n - Name: " + Pname + ", Phone: " + Pphone + ", Email: " + PEmail + ", part: " + part + ", salary: " + salary + ", Date Hired: " + Day );
        }

        public abstract void CaculateBonus();

        public abstract void CaculateVacation();
    }
    
}
