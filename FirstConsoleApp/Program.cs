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


            float temperatureInCelsius = 28.4f;
            Console.WriteLine($"Temperature in Fahrenheit is: {ConvertCelsiusToFahrenheit(temperatureInCelsius)}");
        }

        private static int AddNumber(int first, int second)
        {
            return first + second;
        }

        private static float ConvertCelsiusToFahrenheit(float temperatureInCesius)
        {
            return (float)Math.Round(((temperatureInCesius * 1.8f) + 32f), 2);
        }
    }
}
