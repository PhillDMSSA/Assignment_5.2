using System.Globalization;

namespace Assignment_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get the sum: ");
            int numInput = Convert.ToInt32(Console.ReadLine());

            int result = SumOfString(numInput);

            Console.WriteLine($"The Sum of {numInput} is {result}");
            
        }
        //create a method that converts int to string and adds the sum
        static int SumOfString(int num)
        {
            int sum = 0;
            string intString = num.ToString();

            foreach (char number in intString)
            {
                if (number != '-')
                {
                    sum += number - '0'; 
                }
            }
            return sum;
        }
    }
}
