namespace softUniMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{GetFactorial(a) / b:f2}");
        }

        static int GetFactorial(int n)
        {
            int result = 1;
            for(int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}