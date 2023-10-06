namespace softUniMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            PrintSmallestOfThreeNumbers(a, b, c);
        }

        static void PrintSmallestOfThreeNumbers(int a, int b, int c)
        {
            Console.WriteLine(Math.Min(Math.Min(a, b), Math.Min(b, c)));
        }
    }
}