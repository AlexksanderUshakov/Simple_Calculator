namespace Moe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first value:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("What expression do you want to use = +,-,/,* = ?");

            string otvet = Console.ReadLine();

            if (otvet == "+")
            {
                int z = x + y;
                Console.WriteLine($"Answer: {x} + {y} = {z}");
            }
            else if (otvet == "-")
            {
                int z = x - y;
                Console.WriteLine($"Answer: {x} - {y} = {z}");
            }
            else if (otvet == "*")
            {
                int z = x * y;
                Console.WriteLine($"Answer: {x} * {y} = {z}");
            }
            else if (otvet == "/")
            {
                try
                {
                    int z = x / y;
                    Console.WriteLine($"Answer: {x} / {y} = {z}");
                }
                catch (Exception)
                {

                    Console.WriteLine("Division by zero is not possible!");
                }
            }
            else
            {
                Console.WriteLine("You have entered an invalid value!");
            }

            Console.ReadLine();
        }
    }
}
