namespace EbsEX3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x;
            Console.Write("1. Student \n2. Staff\n3. Faculty\nChon chuc nang: ");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        Student st1 = new Student();
                        st1.input();
                        st1.input1();
                        Console.WriteLine(st1.ToString());
                        break;
                    }
                case 2:
                    {
                        Staff stf1 = new Staff();
                        stf1.input();
                        stf1.input2();
                        Console.WriteLine(stf1.ToString());
                        stf1.CaculateBonus();
                        stf1.CaculateVacation();
                        break;

                    }

                case 3:
                    {   
                        Faculty fl1 = new Faculty();
                        fl1.input();
                        fl1.input2();
                        Console.WriteLine(fl1.ToString());
                        fl1.CaculateBonus();
                        fl1.CaculateVacation();
                        break;

                    }
            }


          

           
            






        }

    }
}