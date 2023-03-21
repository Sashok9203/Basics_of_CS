namespace Basics_of_C_
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            CircleArea();

        }

        static void CircleArea()
        {
            int radius;
            do
            {
                Console.Clear();
                Console.Write(" Enter circle radius : ");
            } while (!int.TryParse(Console.ReadLine(), out radius));
            Console.Write($" Area of circle with radius {radius}  =  {Math.Round(Math.PI * Math.Pow(radius,2),2)}");
            Console.ReadKey();
        }
        static void CircleArea()
        {
            int radius;
            do
            {
                Console.Clear();
                Console.Write(" Enter circle radius : ");
            } while (!int.TryParse(Console.ReadLine(), out radius));
            Console.Write($" Area of circle with radius {radius}  =  {Math.Round(Math.PI * Math.Pow(radius, 2), 2)}");
            Console.ReadKey();
        }

    }
}