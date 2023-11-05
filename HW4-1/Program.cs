using System.Text;

namespace Lesson
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            double firstValue, secondValue;
            string action;

            Console.WriteLine("Enter number: 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number: 2");
            secondValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the sign: '+' '-' '*' '/'");
            action = Console.ReadLine();

            switch (action)

            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case "/":
                    
                    if (secondValue == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    Console.WriteLine(firstValue / secondValue);
                    break;
                default:
                    Console.WriteLine("Wrong!");
                    break;


            }
            Console.ReadLine();


        }
    }
}