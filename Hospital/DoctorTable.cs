using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
     class DoctorTable
    {
        public Hashtable objDotorDetails = new Hashtable();

        public void AcceptDetails()
        {
            string name;
            string address;
            char choice = 'Y';
            

            try
            {
                do
                {
                    Console.Write("Enter the doctor's name :");
                    name = Console.ReadLine();
                    Console.Write("Enter the address :");
                    address = Console.ReadLine();
                    objDotorDetails.Add(name, address);
                    Console.Write("Do you want to add more records? [Y/N] : ");
                    choice = Convert.ToChar(Console.ReadLine());

                } while (choice == 'Y' || choice == 'y');
                    
            }catch (Exception objEx) {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }


        public void DisplayDetails()
        {
            ICollection objCollection = objDotorDetails.Keys;

            Console.WriteLine("\nDetails of doctors :");
            Console.WriteLine("Doctor's Name \t Adress");
            Console.WriteLine("------------- \t ------");

            foreach(string details in objCollection) {
                Console.WriteLine(details + "\t\t"  + objDotorDetails[details]);

            }

            Console.WriteLine("Total number of doctors : " + objDotorDetails.Count);
        }

        public bool Remove()
        {
            string choice;
            Console.Write("Enter the same of the doctor : ");
            choice = Console.ReadLine();
            if (objDotorDetails.ContainsKey(choice))
            {
                objDotorDetails.Remove(choice);
                return true;
            }else 
                return false;
        }


        public void Search()
        {
            string choice;
            Console.Write("Enter the name of the doctor : ");
            choice = Console.ReadLine();
            if(choice != "")
            {
                if (objDotorDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found!");
                    Console.WriteLine("Doctor's Name : {0}", choice);
                    Console.WriteLine("Address : {0}", objDotorDetails);
                }
                else Console.WriteLine("Record Not Found!");

            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }

        
        public void Update()
        {
            string choice;

            Console.Write("Enter the name of the doctor : ");
            choice = Console.ReadLine();

            if (choice != "")
                {
                if (objDotorDetails.ContainsKey(choice))
                {
                    
                    Console.Write("Enter New Adress : ");
                    objDotorDetails[choice] = Console.ReadLine();

                    


                }
                else Console.WriteLine("Record Not Found!");

            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }


    }

}
