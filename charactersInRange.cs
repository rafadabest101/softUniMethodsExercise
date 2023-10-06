namespace softUniMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            if(ch1 <= ch2) PrintBetweenTwoFirstSmallerThenSecond(ch1, ch2);
            else PrintBetweenTwoCharsSecondSmallerThenFirst(ch1, ch2);
        }

        static void PrintBetweenTwoFirstSmallerThenSecond(char ch1, char ch2)
        {
            for(int i = ch1 + 1; i < ch2; i++)
            {
                Console.Write((char)i + " ");
            }
        }
        static void PrintBetweenTwoCharsSecondSmallerThenFirst(char ch1, char ch2)
        {
            for(int i = ch2 + 1; i < ch1; i++)
            {
                Console.Write((char)i + " ");
            }
        }
}