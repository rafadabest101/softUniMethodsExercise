namespace softUniMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if(!ValidateLength(password)) Console.WriteLine("Password must be between 6 and 10 characters");
            if(!ValidateOnlyLettersAndDigits(password)) Console.WriteLine("Password must consist only of letters and digits");
            if(!ValidateAtLeast2Digits(password)) Console.WriteLine("Password must have at least 2 digits");
            if(ValidateLength(password) && ValidateOnlyLettersAndDigits(password) && ValidateAtLeast2Digits(password)) Console.WriteLine("Password is valid");
        }

        static bool ValidateLength(string password)
        {
            if(password.Length >= 6 && password.Length <= 10) return true;
            return false;
        }

        static bool ValidateOnlyLettersAndDigits(string password)
        {
            foreach(char ch in password)
            {
                if(!char.IsLetter(ch) && !char.IsDigit(ch)) return false;
            }
            return true;
        }

        static bool ValidateAtLeast2Digits(string password)
        {
            int digitCount = 0;
            foreach(char ch in password)
            {
                if(char.IsDigit(ch)) digitCount++;
            }
            if(digitCount >= 2) return true;
            return false;
        }
    }
}