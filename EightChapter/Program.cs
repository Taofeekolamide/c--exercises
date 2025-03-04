class Program
{
    /*static int GetMax(int a, int b) {
        return Math.Max(a,  b);
    }*/

    /*static string PrintName(string Name) {
        return Name;
    }*/

    /*static string LastEnglishName(string Number) {
        string LastDigitName = "";
        char LastDigit = Number[Number.Length - 1];

        switch (LastDigit) {
            case '0': LastDigitName = "zero";  break;
            case '1': LastDigitName = "one";   break;
            case '2': LastDigitName = "two";   break;
            case '3': LastDigitName = "three"; break;
            case '4': LastDigitName = "four";  break;
            case '5': LastDigitName = "five";  break;
            case '6': LastDigitName = "six";   break;
            case '7': LastDigitName = "seven"; break;
            case '8': LastDigitName = "eight"; break;
            case '9': LastDigitName = "nine";  break;
            default: LastDigitName = "Invalid word"; break;
        }
        return LastDigitName;
    }*/

    /*static void FindCertainNumber(int Number, params int[] NumberArray) {
        int Count = 0;
        for (int i = 0; i < NumberArray.Length; i++)
        {
            if (NumberArray[i] == Number) {
                Count++;
            }
        }
        Console.WriteLine($"We have {Number} in {Count} places");
    }*/

    /*static void CheckElement(int Position, params int[] Numbers)
    {
        if (Position == 1 || Position > Numbers.Length - 1)
        {
            Console.WriteLine("The position has one neighbour");
        }
        if (Numbers[Position - 1] > Numbers[Position] && Numbers[Position - 1] > Numbers[Position - 2])
        {
            Console.WriteLine("It is greater that the two neighbours");
        }
        else
        {
            Console.WriteLine("It is not greater that the two neighbours");
        }


    }*/

    /*static int FirstOccurrence(params int[] array)
    {
        int result = 0;
        if (array.Length < 3)
        {
            return result = -1;
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                result = i+1;
                break;
            }
            else
            {
                result = -1;
            }
        }
        return result;
    }*/

    /*static void ReversedDecimal(string Decimal) {
        for (int i = Decimal.Length-1; i >= 0; i--)
        {
            Console.WriteLine(Decimal[i]);
        }
    }*/

    /*static void BiggestElement(params int[] arr) {
        int biggest = arr[0];
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] > biggest) {
                biggest = arr[i];
                Console.WriteLine(arr[i]);
            }
        }
        Console.WriteLine(biggest);
    }

    static void SortArray(params int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        for (int i = arr.Length-1; i >= 0; i--) {
            Console.WriteLine(arr[i]);
        }
        
    }*/

    /*static void NFactorial(long N)
    {
        long NFactorial = 1;
        if (N > 0 && N <= 100)
        {
            for (int i = 1; i <= N; i++)
            {
                NFactorial *= i;
            }
            Console.WriteLine(NFactorial);
        } else {
            Console.WriteLine("Number out of range");
        }
        
    }*/


    public static void Main()
    {
        /*Console.Write("Enter Number : ");
        long N = Convert.ToInt32(Console.ReadLine());
        NFactorial(N);*/

        /*SortArray(1, 4, 6, 4, 8, 3, 5, 6, 1, 5, 2);
        BiggestElement(1, 4, 6, 4, 8, 3, 5, 6, 1, 5, 2);*/

        /*Console.Write("Enter Number : ");
        string Number = Console.ReadLine();
        ReversedDecimal(Number);*/

        //Console.WriteLine($"The position of the first occurrence is {FirstOccurrence(3, 1, 6, 4)}");

        /*Console.Write("Enter position : ");
        int Position = Convert.ToInt32(Console.ReadLine());
        CheckElement(Position, 3, 6, 2, 4, 5, 4, 3, 8, 5, 3);*/

        /*Console.Write("Enter Number to check: ");
        int number = int.Parse(Console.ReadLine());
        FindCertainNumber(number, [1, 2, 3, 4, 4, 4, 4, 4, 3, 3, 3, 2, 1, 1, 1, 1, 1, 1, 1]);*/

        /*Console.Write("Enter Number : ");
        string Number = Console.ReadLine();
        Console.Write($"The last digit in word is {LastEnglishName(Number)}");*/

        /*Console.Write("Enter Number One : ");
        int FirstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number Two : ");
        int SecondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GetMax(FirstNumber, SecondNumber));*/

        /*Console.Write("Enter Name : ");
        string TheName = Console.ReadLine();
        Console.Write($"Hello, {PrintName(TheName)!}");*/
    }
}





/*8., 11., 12., 13.*/