using System.Text;

namespace bai1_lap1
{
    static class MyCollege
    {
        // static fields
        public static string CollegeName;
        public static string Address;

        // static constructor
        static MyCollege()
        {
            CollegeName = "FPT Polytechnic";
            Address = "391A Nam Kỳ Khởi Nghĩa, Q.3,TP.Hồ Chí Minh";
        }
        internal class Program
    {
        
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(MyCollege.CollegeName);
            Console.WriteLine(MyCollege.Address);
            Console.Read();
        }
    }
}