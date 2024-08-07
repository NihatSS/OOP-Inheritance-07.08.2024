using Calculator.Data;

namespace Calculator.Service
{
    internal class NumsService
    {
        AppDBContext context = new();

        public Numbers[] GetResult(int num1, int num2) 
        {
            return context.GetNums(num1,num2);
        }

    }
}
