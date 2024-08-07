
namespace Task
{
    internal class Calculator
    {
        public int num1;
        public int num2;


        public Calculator(int num1, int num2)
        {
            this .num1 = num1;
            this .num2 = num2;
        }
        public void GetSum() 
        {
            Console.WriteLine( $"{num1}+{num2}={num1 + num2}");
        }

        public void GetSubstact()
        {
            Console.WriteLine($"{num1}-{num2}={num1 - num2}");
        }

        public void GetMulty() 
        {
            Console.WriteLine($"{num1}*{num2}={num1 * num2}");
        }

        public void GetDivision()
        {
            Console.WriteLine($"{num1}/{num2}={num1 / num2}");
        }
    }
}
