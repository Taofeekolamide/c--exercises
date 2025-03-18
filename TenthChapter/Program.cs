//number 7
// class Program
// {
//     static void SquareRoot()
//     {
//         try
//         {
//             Console.Write("Enter a Number : ");
//             int input = Convert.ToInt32(Console.ReadLine());
//             double Sqrt = Math.Sqrt(input);
//             if (input < 0)
//             {
//                 throw new ArithmeticException("Cannot compute the square root of a negative number.");
//             }
//             else
//             {
//                 Console.WriteLine(Sqrt);
//             }
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("The input is not a number");
//         }
//         finally 
//         {
//             Console.WriteLine("Good Bye");
//         }
//     }
//     static void Main()
//     {
//         SquareRoot();
//     }
// }

//number 8
// class Program
// {
//     static int ReadNumber(int start, int end)
//     {
//         int input = Convert.ToInt32(Console.ReadLine());
//         try
//         {

//             if (input < start || input > end)
//             {
//                 throw new ArgumentOutOfRangeException($"{input} out of range");
//             }

//         }
//         catch (System.FormatException)
//         {
//             throw new FormatException("Error: Invalid input. Please enter a valid integer.");
//         }
//         return input;
//     }
//     static void Main()
//     {
//         int[] numbers = new int[5];
//         int start = 1;
//         int end = 100;

//         Console.WriteLine("Enter number in sequence");
//         try
//         {
//             for (int i = 0; i < 5; i++)
//             {
//                 numbers[i] = ReadNumber(start, end);
//                 start = numbers[i];
//             }
//         }
//         catch (System.Exception e)
//         {
//             Console.WriteLine(e.Message);
//         }
//     }
// }

//Number 9
// using System.IO;
// class Program
// {
//     static void Readfile(string FileName)
//     {
//         TextReader reader = null;
//         try
//         {
//             reader = new StreamReader(FileName);
//             string content = reader.ReadToEnd();
//             Console.WriteLine(content);
//         }
//         catch (FileNotFoundException)
//         {
//             Console.WriteLine("File not found");
//         }
//         finally
//         {
//             if (reader != null)
//             {
//                 reader.Close();
//             }
//         }
//     }
//     static void Main()
//     {
//         try
//         {
//             Readfile("C:\\Users\\USER\\Desktop\\New Text Document.txt");
//         }
//         catch (System.Exception)
//         {
//             Console.WriteLine("An error occured");
//         }
//     }
// }

// number 12
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter Path : ");
//         string FilePath = Console.ReadLine();
//         TextReader reader = null;
//         try
//         {
//             reader = new StreamReader(FilePath);
//             string content = reader.ReadToEnd();
//             Console.WriteLine($"The file says : {content}");
//         }
//         catch (FileNotFoundException)
//         {
//             Console.WriteLine("File could not be found");
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine(e.Message);
//         }
//         finally
//         {
//             if (reader != null)
//             {
//                 reader.Close();
//             }
//         }
//     }
// }

// number 13
using System.Net;
class Program
{
    static void Main()
    {
        Console.Write("Enter video URL : ");
        string fileUrl = Console.ReadLine();

        Console.Write("Enter video URL : ");
        string Destination = Console.ReadLine();

        try
        {
            Console.WriteLine("Downloading file...");
            WebClient webClient = new WebClient();
            webClient.DownloadFile(fileUrl, Destination);
            Console.WriteLine($"Download completed! File saved at: {Destination}");
        }
        catch (WebException ex)
        {
            Console.WriteLine($"Error downloading file: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File I/O error: {ex.Message}");
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}