namespace softUniMethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] commandParts = command.Split(' ');
                switch(commandParts[0])
                {
                    case $"exchange":
                        Exchange(arr, int.Parse(commandParts[1]));
                        break;
                    case $"max":
                        if(commandParts[1] == "even")
                        {
                            if(MaxEven(arr) >= 0) Console.WriteLine(MaxEven(arr));
                            else Console.WriteLine("No matches");
                        }
                        else
                        {
                            if(MaxOdd(arr) >= 0) Console.WriteLine(MaxOdd(arr));
                            else Console.WriteLine("No matches");
                        }
                        break;
                    case $"min":
                        if(commandParts[1] == "even")
                        {
                            if(MinEven(arr) >= 0) Console.WriteLine(MinEven(arr));
                            else Console.WriteLine("No matches");
                        }
                        else
                        {
                            if(MinOdd(arr) >= 0) Console.WriteLine(MinOdd(arr));
                            else Console.WriteLine("No matches");
                        }
                        break;
                    case $"first":
                        int firstCount = int.Parse(commandParts[1]);
                        if(commandParts[2] == "even")
                        {
                            if(firstCount <= arr.Length) Console.WriteLine('[' + string.Join(", ", FirstEven(arr, firstCount)) + ']');
                            else Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if(firstCount <= arr.Length) Console.WriteLine('[' + string.Join(", ", FirstOdd(arr, firstCount)) + ']');
                            else Console.WriteLine("Invalid count");
                        }
                        break;
                    case $"last":
                        int lastCount = int.Parse(commandParts[1]);
                        if(commandParts[2] == "even")
                        {
                            if(lastCount <= arr.Length) Console.WriteLine('[' + string.Join(", ", LastEven(arr, lastCount)) + ']');
                            else Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if(lastCount <= arr.Length) Console.WriteLine('[' + string.Join(", ", LastOdd(arr, lastCount)) + ']');
                            else Console.WriteLine("Invalid count");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine('[' + string.Join(", ", arr) + ']');
        }

        static void Exchange(int[] arr, int index)
        {
            if(index < 0 || index >= arr.Length) Console.WriteLine("Invalid index");
            else
            {
                int[] firstPartOfArr = new int[index + 1];
                int[] secondPartOfArr = new int[arr.Length - 1 - index];
                for(int i = 0; i < arr.Length; i++)
                {
                    if(i <= index) firstPartOfArr[i] = arr[i];
                    else secondPartOfArr[i - 1 - index] = arr[i];
                }
                for(int i = 0; i < arr.Length; i++)
                {
                    if(i < secondPartOfArr.Length) arr[i] = secondPartOfArr[i];
                    else arr[i] = firstPartOfArr[i - secondPartOfArr.Length];
                }
            }
        }

        static int MaxEven(int[] arr)
        {
            int maxEvenNumber = int.MinValue;
            int maxEvenIndex = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0 && arr[i] >= maxEvenNumber)
                {
                    maxEvenNumber = arr[i];
                    maxEvenIndex = i;
                }
            }
            return maxEvenIndex;
        }

        static int MaxOdd(int[] arr)
        {
            int maxOddNumber = int.MinValue;
            int maxOddIndex = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 1 && arr[i] >= maxOddNumber)
                {
                    maxOddNumber = arr[i];
                    maxOddIndex = i;
                }
            }
            return maxOddIndex;
        }

        static int MinEven(int[] arr)
        {
            int minEvenNumber = int.MaxValue;
            int minEvenIndex = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0 && arr[i] <= minEvenNumber)
                {
                    minEvenNumber = arr[i];
                    minEvenIndex = i;
                }
            }
            return minEvenIndex;
        }

        static int MinOdd(int[] arr)
        {
            int minOddNumber = int.MaxValue;
            int minOddIndex = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 1 && arr[i] <= minOddNumber)
                {
                    minOddNumber = arr[i];
                    minOddIndex = i;
                }
            }
            return minOddIndex;
        }

        static int[] FirstEven(int[] arr, int count)
        {
            int[] firstEven = new int[count];
            int foundNums = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    firstEven[foundNums] = arr[i];
                    foundNums++;
                }
                if(foundNums == count) break;
            }
            int[] firstFoundEven = new int[foundNums];
            for(int i = 0; i < firstFoundEven.Length; i++)
            {
                firstFoundEven[i] = firstEven[i];
            }
            if(firstFoundEven.Length > 0) return firstFoundEven;
            else return new int[0];
        }

        static int[] FirstOdd(int[] arr, int count)
        {
            int[] firstOdd = new int[count];
            int foundNums = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 == 1)
                {
                    firstOdd[foundNums] = arr[i];
                    foundNums++;
                }
                if(foundNums == count) break;
            }
            int[] firstFoundOdd = new int[foundNums];
            for(int i = 0; i < firstFoundOdd.Length; i++)
            {
                firstFoundOdd[i] = firstOdd[i];
            }
            if(firstFoundOdd.Length > 0) return firstFoundOdd;
            else return new int[0];
        }

        static int[] LastEven(int[] arr, int count)
        {
            int[] lastEven = new int[count];
            int foundNums = 0;
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                if(arr[i] % 2 == 0)
                {
                    lastEven[foundNums] = arr[i];
                    foundNums++;
                }
                if(foundNums == count) break;
            }
            int[] lastFoundEven = new int[foundNums];
            for(int i = 0; i < lastFoundEven.Length; i++)
            {
                lastFoundEven[i] = lastEven[i];
            }
            if(lastFoundEven.Length > 0) return lastFoundEven;
            else return new int[0];
        }

        static int[] LastOdd(int[] arr, int count)
        {
            int[] lastOdd = new int[count];
            int foundNums = 0;
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                if(arr[i] % 2 == 1)
                {
                    lastOdd[foundNums] = arr[i];
                    foundNums++;
                }
                if(foundNums == count) break;
            }
            int[] lastFoundOdd = new int[foundNums];
            for(int i = 0; i < lastFoundOdd.Length; i++)
            {
                lastFoundOdd[i] = lastOdd[i];
            }
            if(lastFoundOdd.Length > 0) return lastFoundOdd;
            else return new int[0];
        }
    }
}