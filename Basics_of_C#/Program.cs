using System.Diagnostics.Metrics;

namespace Basics_of_C_
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            CircleArea ca = new CircleArea();
            ca.getArea();

            GuessNumber gn = new GuessNumber();
            gn.guess();

            Rectangle rect = new Rectangle();
            rect.Draw();

            HarvestingHay hh = new HarvestingHay();
            hh.harvestingHay();

            Triangles triangles = new Triangles();
            triangles.Draw();
        }

        class CircleArea
        {
            private int radius;
            public  void getArea()
            {
                radius = getValue(" Enter circle radius : ");
                Console.Write($" Area of circle with radius {radius}  =  {Math.Round(Math.PI * Math.Pow(radius, 2), 2)}");
                Console.ReadKey();
            }
        }

        class GuessNumber
        {
            private Random rnd;
            private int number;
            private int userNumber;

            public GuessNumber()
            {
                rnd = new Random();
                number = userNumber = 0;
            }
            public void guess()
            {
                number = rnd.Next(11);
                for (int i = 0; i < 3; i++)
                {
                    userNumber = getValue($" Enter number 0 - 10 (attempt {i + 1}): ");
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
        }

        class Rectangle
        {
            private int width,height,Y,X;
            
            public void Draw()
            {
                width = getValue(" Enter width of rectangle : ");
                height = getValue(" Enter width of height : ");
                X = getValue(" Enter X cootdinate : ");
                Y = getValue(" Enter Y cootdinate : ");
                Console.Clear();
                for (int y = 0; y < height; y++)
                {
                    Console.SetCursorPosition(X, Y + y);
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
                Console.ResetColor();
                Console.ReadKey();
            }
        }

        class HarvestingHay
        {
            private int hayMowers;
            private int time,stime;
            public void harvestingHay()
            {
                Console.Clear();
                hayMowers = getValue(" Enter hay mowers count : ");
                time = getValue(" Enter first hay mowers work time (hours): ") * 60;
                for (int i = 0; i < hayMowers; i++)
                    stime += time + i * 10;
                Console.WriteLine($" The entire team worked for {stime / 60} hours and {stime % 60} minutes");
                Console.ReadKey();
            }
        }

        class Triangles
        {
            private int size;
            private int tbase;

            public void Draw()
            {
                Console.Clear();
                do
                {
                    size = getValue(" Enter triangle size (1 - 6): ");
                } while (size < 1 || size > 6);
                Console.Clear();
                tbase = size * 2 - 1;
                for (int i = 0; i < size; i++)
                {
                    Console.SetCursorPosition(2 + i * (tbase + 4), 0);
                    for (int k = 0; k < size; k++)
                    {
                        Console.SetCursorPosition(2 + i * (tbase + 4), k);
                        for (int y = 0; y < tbase; y++)
                        {
                            if (k == size - 1 || (y == tbase / 2 - k) || (y == tbase / 2 + k)) Console.Write("*");
                            else Console.Write(" ");
                        }
                    }
                }
                Console.ReadKey();
            }
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