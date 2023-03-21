using System.Diagnostics.Metrics;

namespace Basics_of_C_
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            circleArea();
            guessNumber();
            drawRectangle();
            harvestingHay();
        }

        static void circleArea()
        {
            int radius = getValue(" Enter circle radius : ");
            Console.Write($" Area of circle with radius {radius}  =  {Math.Round(Math.PI * Math.Pow(radius,2),2)}");
            Console.ReadKey();
        }
        static void guessNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(11);
           
            for (int i = 0; i < 3; i++)
            {
                int userNumber = getValue($" Enter number 0 - 10 (attempt {i + 1}): ");
                if (userNumber == number)
                {
                    Console.WriteLine(" Congratulation !!! You guess the number !!!!");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine($" You didn't guess the number \"{number}\"");
            Console.ReadKey();
        }

        static void drawRectangle()
        {
            int width = getValue(" Enter width of rectangle : ");
            int height = getValue(" Enter width of height : ");
            int X = getValue(" Enter X cootdinate : ");
            int Y = getValue(" Enter Y cootdinate : ");
            Console.Clear();
            for (int y = 0; y < height; y++)
            {
                Console.SetCursorPosition(X, Y+y);
                for (int i = 0; i < width; i++)
                {
                    if (y == 0) Console.ForegroundColor = ConsoleColor.Red;
                    else if (y == height - 1) Console.ForegroundColor = ConsoleColor.Yellow;
                    else if (i == 0) Console.ForegroundColor = ConsoleColor.Green;
                    else if (i == width - 1) Console.ForegroundColor = ConsoleColor.Blue;
                    else
                    {
                        Console.Write(" ");
                        continue;
                    }
                   Console.Write("*");
                }
            }
            Console.ReadKey();
        }

        static void harvestingHay()
        {
            Console.Clear();
            int hayMowers = getValue(" Enter hay mowers count : ");
            int  time = getValue(" Enter first hay mowers work time (hours): ") * 60;
            for (int i = 0; i < hayMowers - 1; i++)
                time += time + 10;
            Console.WriteLine($" The entire team worked for {time / 60} hours and {time % 60} minutes");
            Console.ReadKey();
        }

        static void Triangles()
        {
            Console.Clear();
            int size = getValue(" Enter triangle size : ");
            


            Console.ReadKey();
        }

        static int  getValue(string message)
        {
            int value;
            do
            {
                Console.Clear();
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out value));
            return value;
        }

    }
}