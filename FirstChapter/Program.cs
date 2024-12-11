/* 1. Declare several variables by selecting for each one of them the most 
appropriate of the types sbyte, byte, short, ushort, int, uint, long
and ulong in order to assign them the following values: 52,130; -115; 
4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 
1990; 123456789123456789. */

sbyte var1 = -115;
byte var2 = 97;
short var3 = -10000;
ushort var4 = 20000;
int var5 = 4825932;
uint var6 = 970700000;
byte var7 = 224;
ulong var8 = 123456789123456789;
sbyte var9 = -44;
int var10 = -1000000;
ushort var11 = 1990;
long var12 = 52130; 


/*2. Which of the following values can be assigned to variables of type float, 
double and decimal: 5f, -5.01f, 34.567839023; 12.345f; 8923.1234857;
3456.091124875956542151256683467?*/


/*3. Write a program, which compares correctly two real numbers with 
accuracy at least 0.000001.*/
int FirstNumber = 5;
int SecondNumber = 4;
bool equal = Math.Abs(FirstNumber - SecondNumber) < 0.000001;

/*4. Initialize a variable of type int with a value of 256 in
hexadecimal format (256 is 100 in a numeral system with base 16).*/
int number = 0x100;

/*5. Declare a variable of type char and assign it as a value the character, 
which has Unicode code, 72 (use the Windows calculator in order to find 
hexadecimal representation of 72).*/
char character = '\u0048';

/*6. Declare a variable isMale of type bool and assign a value to it depending 
on your gender.*/
bool isMale = true;

/*7. Declare two variables of type string with values "Hello" and "World". 
Declare a variable of type object. Assign the value obtained of 
concatenation of the two string variables (add space if necessary) to this 
variable. Print the variable of type object.*/
string WordOne = "Hello";
string WordTwo = "World";
object Concat = $"{WordOne} {WordTwo}";
Console.WriteLine(Concat);

/*8. Declare two variables of type string and give them values "Hello" and 
"World". Assign the value obtained by the concatenation of the two 
variables of type string (do not miss the space in the middle) to a 
variable of type object. Declare a third variable of type string and 
initialize it with the value of the variable of type object (you should use 
type casting).136 Fundamentals of Computer Programming with C#*/
string FirstWord = "Hello";
string SecondWord = "World";
object result = FirstWord + " " + SecondWord;
string output = (string)result;

/*9. Declare two variables of type string and assign them a value “The 
"use" of quotations causes difficulties.” (without the outer quotes). 
In one of the variables use quoted string and in the other do not use it.*/
string First = "The \"use\" of quotations causes difficulties.";
string Second = @"The ""use"" of quotations causes difficulties.";

/*10. Write a program to print a figure in the shape of a heart by the sign "o".*/
Console.WriteLine("o           o");
Console.WriteLine(" o         o");
Console.WriteLine("  o       o");
Console.WriteLine("   o     o");
Console.WriteLine("    o   o");
Console.WriteLine("     o o ");
Console.WriteLine("      o ");

/*11. Write a program that prints on the console isosceles triangle which 
sides consist of the copyright character "©".*/
Console.WriteLine("      o ");
Console.WriteLine("     o o ");
Console.WriteLine("    o   o");
Console.WriteLine("   o     o");
Console.WriteLine("  o       o");
Console.WriteLine(" o         o");
Console.WriteLine("ooooooooooooo");


/*12. A company dealing with marketing wants to keep a data record of its 
employees. Each record should have the following characteristic – first 
name, last name, age, gender (‘m’ or ‘f’) and unique employee number 
(27560000 to 27569999). Declare appropriate variables needed to 
maintain the information for an employee by using the appropriate data 
types and attribute names.*/
string FirstName = "Olamide";
string LastName = "Taofeek";
int age = 19;
char gender = 'm';
int EmployeeNum = 60000;

/*13. Declare two variables of type int. Assign to them values 5 and 10 
respectively. Exchange (swap) their values and print them.*/
int a = 5;
int b = 10;

int temporary = a;
a = b;
b = temporary;
Console.WriteLine(a);
Console.WriteLine(b);
