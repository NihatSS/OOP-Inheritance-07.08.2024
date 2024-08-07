namespace Calculator.Data
{
    internal class AppDBContext
    {
        public Numbers[] GetNums(int num1, int num2)
        {
            Numbers nums = new()
            {
                num1= num1,
                num2= num2
            };

            Numbers[] numbers = { nums };
            return numbers;
        }
    }
}
