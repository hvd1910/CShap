using System;

namespace InheritDmo1
{
    class People {
        protected int id;
        protected string name;
        protected string email;
        

        public void Input()
        {
            Console.Write("Enter id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter email: ");
            email = Console.ReadLine();
           
           
        }
        public void showInput()
        {
            Console.WriteLine("Id: {0} \nName: {1}\nEmail: {2} ", id, name, email);

        }

        
       

    }
}
