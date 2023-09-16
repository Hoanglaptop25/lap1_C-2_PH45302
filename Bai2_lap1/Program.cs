using System.Text;

namespace Bai2_lap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //access static members
            Student.DisplayCollegeDetails();

            // acess non-static members
            Console.WriteLine();
            Student s1 = new Student();
            Student s2 = new Student();
            s1.SetStudentDetails("Hoangdm", "C#2");
            s2.SetStudentDetails("Phuonghl", "MBA");
            s1.DisplayStudentDetails();
            s2.DisplayStudentDetails();
            Console.Read();
        }
    }
}