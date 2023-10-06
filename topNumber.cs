namespace softUniMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(CheckIfTopNumber(i)) Console.WriteLine(i);
            }
        }

        static bool CheckIfTopNumber(int n)
        {
            if(GetDigitSum(n) % 8 == 0 && CheckIfContainsOddDigit(n)) return true;
            return false;
        }

        static int GetDigitSum(int n)
        {
            int digitSum = 0;
            foreach(char digit in n.ToString())
            {
                digitSum += digit - '0';
            }
            return digitSum;
        }

        static bool CheckIfContainsOddDigit(int n)
        {
            foreach(char digit in n.ToString())
            {
                if(int.Parse(digit.ToString()) % 2 == 1) return true;
            }
            return false;
        }
    }
}