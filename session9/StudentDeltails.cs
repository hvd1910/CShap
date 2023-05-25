namespace Students
{
    class StudentDetails
    {
        string _studName = "Alexander";
        int  _studId = 30;

        public StudentDetails() {
            Console.WriteLine("Student Name: " + _studName);
            Console.WriteLine("Student ID: " + _studId);
        }
    }
}