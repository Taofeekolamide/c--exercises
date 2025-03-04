/*1. Write a program, which reads from the console a year and checks if it is 
a leap year.
class Program
{
    static void LeapYear(int years)
    {
        if (DateTime.IsLeapYear(years))
        {
            Console.WriteLine($"{years} is a leap year");
        }
        else
        {
            Console.WriteLine($"{years} is not a leap year");
        }
    }
    static void Main()
    {
        LeapYear(2025);
    }
}*/

/*2. Write a program, which generates and prints on the console 10 random 
numbers in the range [100, 200].
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(random.Next(100, 201));
}*/

/*3. Write a program, which prints, on the console which day of the week is 
today.
Console.WriteLine(DateTime.Today.DayOfWeek);*/

/*4. Write a program, which prints on the standard output the count of days, 
hours, and minutes, which have passes since the computer is 
started until the moment of the program execution. For the 
implementation use the class Environment.
Console.WriteLine(Environment.TickCount);
int seconds = Environment.TickCount / 1000;
int minutes = seconds / 60;
int hours = minutes / 60;
int days = hours / 24;
int Allhours = hours % 24;
int Allminutes = minutes % 60;
int Allseconds = seconds % 60;
Console.WriteLine($"it has been {hours} hours since your computer started which is {days} days {Allhours} hours {Allminutes} minutes {Allseconds} seconds");*/


/*5. Write a program which by given two sides finds the hypotenuse of a 
right triangle. Implement entering of the lengths of the sides from the 
standard input, and for the calculation of the hypotenuse use methods of 
the class Math.
Console.Write("Enter the adjacent length : ");
double adj = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the opposite length : ");
double opp = Convert.ToDouble(Console.ReadLine());
adj *= adj;
opp *= opp;
double hyp = Math.Sqrt(adj + opp);
Console.WriteLine(hyp);*/

/*6. Write a program which calculates the area of a triangle with the 
following given: - three sides; - side and the altitude to it; - two sides and the angle between them in degrees. 
//three sides of the triangle 𝑆 = √𝑝(𝑝 −𝑎)(𝑝−𝑏)(𝑝−𝑐)
Console.Write("Enter a side : ");
int a  = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b side : ");
int b  = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b side : ");
int c  = Convert.ToInt32(Console.ReadLine());

int p = (a+b+c)/2;
double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
Console.WriteLine(S);

//area
Console.Write("Enter the base of the triangle: ");
double baseLength = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the height (altitude) of the triangle: ");
double height = Convert.ToDouble(Console.ReadLine());

double area = (baseLength*height)/2;
Console.Write(area);

Console.Write("Enter side a : ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter side b : ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter side y : ");
double y = Convert.ToDouble(Console.ReadLine());

double S = (a*b*Math.Sin(y * (Math.PI / 180)))/2;
Console.Write(S);*/


/*7. Define one more namespace and make a class, which 
calls the classes Cat and Sequence, in it.

using CreatingAndUsingObjects;

namespace CreatingAndUsingObjects
{
    class Cat
    {
        public string Name;
        public int Age;
        public Cat()
        {
            this.Name = name;
            this.Age = age;
        }
        public void Meow()
        {
            Console.WriteLine($"{this.Name} {this.Age}");
        }
    }

    class Sequence
    {
        public int count = 1;
        public int Count()
        {
            return count++;
        }
    }
}

namespace Objects
{
    //using CreatingAndUsingObjects;

    class MainProgram
    {
        static void Main()
        {
            Cat cat = new Cat();

            cat.Meow();

            Sequence sequence = new Sequence();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sequence.Count());
            }
        }
    }

}*/

/*8. Write a program which creates 10 objects of type Cat, gives them names 
CatN, where N is a unique serial number of the object, and in the end call 
the method SayMiau() for each of them. For the implementation use the 
namespace CreatingAndUsingObjects. 

class Cat
{
    public string Name;
    public Cat(string name)
    {
        this.Name = name;
    }

    public void SayMeow()
    {
        Console.WriteLine($"{Name} says miau");
    }

    static void Main()
    {
        Cat[] cats = new Cat[10];

        for (int i = 0; i < cats.Length; i++)
        {
            cats[i] = new Cat($"Cat{i + 1}");
        }
        foreach (var item in cats)
        {
            item.SayMeow();
        }
    }
}*/

/*9. You are given a sequence of positive integer numbers given as string 
of numbers separated by a space. Write a program, which calculates 
their sum. Example: "43 68 9 23 318"  461. 

using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string numbers = "43 68 9 23 318";
        int result = 0;
        string[] numArray = numbers.Split(' ');
        for (int i = 0; i < numArray.Length; i++)
        {
            int Con = int.Parse(numArray[i]);
            result += Con;
        }
        Console.WriteLine(result);
    }
}*/

/*11. Write a program, which generates a random advertising message for 
some product. The message has to consist of laudatory phrase, followed 
by a laudatory story, followed by author (first and last name) and city, 
which are selected from predefined lists. For example, let’s have the 
following lists: - Laudatory phrases: {"The product is excellent.", "This is a great 
product.", "I use this product constantly.", "This is the best product 
from this category."}. - Laudatory stories: {"Now I feel better.", "I managed to change.", 
"It made some miracle.", "I can’t believe it, but now I am feeling 
great.", "You should try it, too. I am very satisfied."}. - First name of the author: {"Dayan", "Stella", "Hellen", "Kate"}. - Last name of the author: {"Johnson", "Peterson", "Charls"}. - Cities: {"London", "Paris", "Berlin", "New York", "Madrid"}. 
Then the program would print randomly generated advertising message 
like the following: 
I use this product constantly. You should try it, too. I am 
very satisfied. -- Hellen Peterson, Berlin 

class Program
{
    static void Main()
    {
        Random random = new Random();
        string[] LaudatoryPhrases = { "The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category." };
        string[] LaudatoryStories = { "Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too.I am very satisfied." };
        string[] FirstNameOfTheAuthor = { "Dayan", "Stella", "Hellen", "Kate" };
        string[] LastNameOfTheAuthor = { "Johnson", "Peterson", "Charls" };
        string[] Cities = { "London", "Paris", "Berlin", "New York", "Madrid" };
        Console.WriteLine($"{LaudatoryPhrases[random.Next(LaudatoryPhrases.Length)]} {LaudatoryStories[random.Next(LaudatoryStories.Length)]} {FirstNameOfTheAuthor[random.Next(FirstNameOfTheAuthor.Length)]} {LastNameOfTheAuthor[random.Next(LastNameOfTheAuthor.Length)]} {Cities[random.Next(Cities.Length)]}");
    }
}*/

