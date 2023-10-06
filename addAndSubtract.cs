namespace softUniMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(GetSum(a, b), c));
        }

        static int GetSum(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}