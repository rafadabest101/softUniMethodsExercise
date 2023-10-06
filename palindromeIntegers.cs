namespace softUniMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while(command != "END")
            {
                int n = int.Parse(command);
                Console.WriteLine(CheckIfPalindrome(n).ToString().ToLower());
                command = Console.ReadLine();
            }
        }

        static bool CheckIfPalindrome(int n)
        {
            string nStr = n.ToString();
            for(int i = 0; i < nStr.Length; i++)
            {
                if(nStr[i] != nStr[nStr.Length - 1 - i]) return false;
            }
            return true;
        }
    }
}