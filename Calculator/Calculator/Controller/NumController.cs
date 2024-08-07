using Calculator.Service;

namespace Calculator.Controller
{
    internal class NumController
    {
        NumsService numsService = new NumsService();

        public void GetSum(int num1, int num2) 
        {
            var result = numsService.GetResult(num1, num2);
            foreach (var item in result)
            {
                Console.WriteLine($"{num1}+{num2}={num1+num2}");
            }
        }
        public void GetSubtract(int num1, int num2)
        {
            var result = numsService.GetResult(num1, num2);
            foreach (var item in result)
            {
                Console.WriteLine($"{num1}-{num2}={num1 - num2}");
            }
        }
        public void GetMulty(int num1, int num2)
        {
            var result = numsService.GetResult(num1, num2);
            foreach (var item in result)
            {
                Console.WriteLine($"{num1}*{num2}={num1 * num2}");
            }
        }
        public void GetDivision(int num1, int num2)
        {
            var result = numsService.GetResult(num1, num2);
            foreach (var item in result)
            {
                Console.WriteLine($"{num1}/{num2}={num1 / num2}");
            }
        }

    }
}
