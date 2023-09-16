using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_lap1
{
    internal class Student
    {
        // non-static data members
        public string StudentName;
        public string Course;

        public void SetStudentDetails(string StuName, string Cou)
        {
            StudentName = StuName;
            Course = Cou;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine(StudentName + " - " + Course);
        }
        // static data members
        public static string CollegeName = "FPT PolyTechnic";
        public static string CollegeAddress = "391A Nam Kỳ Khởi Nghĩa, Phường 8, Quận 3, Hồ Chí Minh";
        // static methods
        public static void DisplayCollegeDetails()
        {
            Console.WriteLine(CollegeName);
            Console.WriteLine(CollegeAddress);
        }
    }
}
