namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** This is my first console App! ***");
            Console.WriteLine("Hello, World!");

            int var1 = 10;
            int var2 = 20;

            Console.WriteLine($"Number is: {AddNumber(var1, var2)}");
        }

        private static int AddNumber(int first, int second)
        {
            return first + second;
        }
    }
}