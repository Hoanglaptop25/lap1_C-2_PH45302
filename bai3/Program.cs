namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {

           clsCalculation objCal = new clsCalculation();
            objCal.Substraction(2,5);
            objCal.Addition(2,5);
            objCal.Multiplication(2,5);
            objCal.Division(2,5);
        }
    }

    public partial class clsCalculation
    {
        public void Addition(int a , int b)
        {
            Console.WriteLine("Output Addition is:{0} ",a+b);
        }
        internal void Substraction(int a , int b)
        {
            Console.WriteLine("Output Substraction is:{0} ", a - b);

              }
    }

    public partial class clsCalculation
    {
        public void Multiplication(int a, int b)
        {
            Console.WriteLine("Output Addition is:{0} ",a*b);
        }
        public void Division(int a,int b)
        {
            Console.WriteLine("Output Substraction is:{0} ", a / b);
        }
    }
}