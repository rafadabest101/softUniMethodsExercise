namespace softUniMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(GetVowelCount(str));
        }

        static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            foreach(char letter in str)
            {
                if(char.ToLower(letter) == 'a') vowelCount++;
                else if(char.ToLower(letter) == 'o') vowelCount++;
                else if(char.ToLower(letter) == 'u') vowelCount++;
                else if(char.ToLower(letter) == 'i') vowelCount++;
                else if(char.ToLower(letter) == 'e') vowelCount++;
            }
            return vowelCount;
        }
    }
}