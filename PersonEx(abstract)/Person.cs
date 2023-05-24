using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbsEX3
{
         class Person
    {
        protected string name;
        protected string phone;
        protected string email;

        public Person()
        {

        }
        protected Person(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        public string Pname
        {
            get{ return name; }

            set { name = value; }
        }

        public string PEmail
        {
            get { return email; }
            set { email = value; }
        }
        
        public string Pphone
        {
            get { return phone; }
            set { phone = value;}
        }

        public  void input()
        {
            
            Console.Write("Enter Name: ");
            name =  Console.ReadLine();
            Console.Write("Enter Phone: ");
            phone = Console.ReadLine();
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
            Person pst1 = new Person(name, phone, email);
              

        }
        public virtual String ToString()
        {
            return ("INFO Student:\n - Name: " + Pname + ", Phone: " + Pphone + ", Email: " + PEmail );
        }

    }
}
