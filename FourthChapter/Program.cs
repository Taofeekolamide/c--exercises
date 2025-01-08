/*Write an if-statement that takes two integer variables and exchanges
their values if the first one is greater than the second one.*/
Console.Write("Enter int a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter int b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) {
    int c = a;
    a = b;
    b = c;
    Console.WriteLine($"{a} {b}");
}

/*2. Write a program that shows the sign (+ or -) of the product of three real
numbers, without calculating it. Use a sequence of if operators.*/
Console.Write("Enter integer: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer: ");
int c = Convert.ToInt32(Console.ReadLine());

int negativeCount = 0;
string sign = "+";
if (a < 0) {
    negativeCount++;
}
if (b < 0) {
    negativeCount++;
}
if (c < 0) {
    negativeCount++;
}
if (negativeCount % 2 == 1)
{
    sign = "-";
}
Console.WriteLine($"The sign of the product is {sign}");

/*3. Write a program that finds the biggest of three integers, using nested
if statements.*/
Console.Write("Enter int a: ");int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter int b: ");int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter int c: ");int c = Convert.ToInt32(Console.ReadLine());
int greatest = 0;
if (a > b) {
    if (a > c) {
        greatest = a;
    }else {
        greatest = c;
    }
}else {
    if (b > a) {
    greatest = b;
    } else {
        greatest = c;
    }
}
Console.WriteLine(greatest);

/*4. Sort 3 real numbers in descending order. Use nested if statements.*/
Console.Write("Enter int a: ");int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter int b: ");int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter int c: ");int c = Convert.ToInt32(Console.ReadLine());
int first = 0;
int second = 0;
int third = 0;
if (a > b) {
    if (a > c) {
        if (b > c) {
            first = a;second = b;third = c;
        }else {
            first = a;second = c;third = b;
        }
    }else {
        first = c;second = a;third = b;
    }
} else {
    if (b > a) {
        if (b > c) {
            if(a > c) {
                first = b;second = a;third = c;
            } else {
                first = b;second = c; third = a;
            }
        } else {
            first = c;second = b; third = a;
        }
    } 
}

Console.WriteLine($"{first}\n{second}\n{third}");

/*5. Write a program that asks for a digit (0-9), and depending on the input,
shows the digit as a word (in English). Use a switch statement.*/

Console.Write("Enter int between 0-9: ");
int a = Convert.ToInt32(Console.ReadLine());
switch (a) {
    case 0: Console.Write("zero"); break;
    case 1: Console.Write("one"); break;
    case 2: Console.Write("two"); break;
    case 3: Console.Write("three"); break;
    case 4: Console.Write("four"); break;
    case 5: Console.Write("five"); break;
    case 6: Console.Write("six"); break;
    case 7: Console.Write("seven"); break;
    case 8: Console.Write("eight"); break;
    case 9: Console.Write("nine"); break;
    default: Console.Write("enter number between 0 to 9"); break;
}

/*6. Write a program that gets the coefficients a, b and c of a quadratic 
equation: ax2 + bx + c, calculates and prints its real roots (if they exist). 
Quadratic equations may have 0, 1 or 2 real roots. */

/*7. Write a program that finds the greatest of given 5 numbers.*/
Console.Write("Enter integer one: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer two: ");
int two = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer three: ");
int threee = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer four: ");
int four = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer five: ");
int five = Convert.ToInt32(Console.ReadLine());

int greatest = one;
if(two > greatest) {
    greatest = two;
}
if(threee > greatest) {
    greatest = threee;
}
if (four > greatest) {
    greatest = four;
}
if(five > greatest) {
    greatest = five;
}
Console.WriteLine($"The greatest is integer one {greatest}");

/*8. Write a program that, depending on the user’s choice, inputs int, double
or string variable. If the variable is int or double, the program
increases it by 1. If the variable is a string, the program appends "*" at
the end. Print the result at the console. Use switch statement.*/
Console.Write("Enter int or double or string : ");
string ans = Console.ReadLine();

switch (ans) {
    case "int":
    Console.Write("Enter int : ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The end result for integrer is {a+1}");
    break;

    case "double":
    Console.Write("Enter double : ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"The end result for double is {b+1}");
    break;

    case "string":
    Console.Write("Enter string : ");
    string c = Console.ReadLine();
    Console.WriteLine($"The end result for string is {c}*");
    break;
}


/*9. We are given 5 integer numbers. Write a program that finds those
subsets whose sum is 0. Examples:
- If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1
is 0.
- If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets
with sum 0.*/
int[] ints = {3, 1, -7, 35, 22};
for (int i = 0; i < 5; i++) {
    Console.WriteLine(ints[i] + ints[i+1] + ints[i+2]);
}

/*10. Write a program that applies bonus points to given scores in the range
[1…9] by the following rules:*/

Console.Write("Enter integer score: ");
int score = Convert.ToInt32(Console.ReadLine());
if (score > 0 && score < 4) {
    Console.WriteLine($"{score * 10}");
} else
if (score > 3 && score < 7) {
    Console.WriteLine($"{score * 100}");
}else
if (score > 6 && score < 10) {
    Console.WriteLine($"{score * 1000}");
}else {
    Console.WriteLine("error");
}

/*11. * Write a program that converts a number in the range [0…999] to
words, corresponding to the English pronunciation. Examples:
- 0 --> "Zero"
- 12 --> "Twelve"
- 98 --> "Ninety eight"
- 273 --> "Two hundred seventy three"
- 400 --> "Four hundred"
- 501 --> "Five hundred and one"
- 711 --> "Seven hundred and eleven"
*/