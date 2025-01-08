/*1. Write an expression that checks whether an integer is odd or even.*/

Console.Write("Enter to check even or odd number: ");
int integer = Convert.ToInt32(Console.ReadLine());
bool oddEven = integer % 2 == 0;
Console.WriteLine(oddEven);

/*2. Write a Boolean expression that checks whether a given integer is 
divisible by both 5 and 7, without a remainder.*/

Console.Write("Enter number: ");
int integer2 = Convert.ToInt32(Console.ReadLine());
bool expression = integer2 % 5 == 0 && integer2 % 7 == 0;
Console.WriteLine(expression);

/*3. Write an expression that looks for a given integer if its third digit (right 
to left) is 7.*/

Console.Write("Enter four digit numbernumber: ");
int integer3 = Convert.ToInt32(Console.ReadLine());
int thirddigit = integer3 % 1000 / 100;
Console.WriteLine(thirddigit);
if (thirddigit == 7)
{
    Console.WriteLine("The third digit is seven");
}else {
    Console.WriteLine("The third digit is not seven");
}
*/
/*4. Write an expression that checks whether the third bit in a given integer 
is 1 or 0.*/
Console.WriteLine("Enter number");
string number = Console.ReadLine();
int bit = number[2] - '0';
Console.WriteLine(bit); 
/*5. Write an expression that calculates the area of a trapezoid by given 
sides a, b and height h.*/

Console.Write("Enter a side: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b side: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter height: ");
double height = Convert.ToDouble(Console.ReadLine());

double trapArea = (a + b) * height / 2;
Console.WriteLine(trapArea);

/*6. Write a program that prints on the console the perimeter and the area 
of a rectangle by given side and height entered by the user.*/

Console.Write("Enter a length: ");
double length = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b width: ");
double width = Convert.ToDouble(Console.ReadLine());
double area = length * width;
Console.WriteLine(area);
double perimeter = 2*(length + width);
Console.WriteLine(perimeter);

/*7. The gravitational field of the Moon is approximately 17% of that on the 
Earth. Write a program that calculates the weight of a man on the 
moon by a given weight on the Earth.*/

Console.Write("Enter a weight: ");
double weight = Convert.ToDouble(Console.ReadLine());
double output = weight * 0.17;
Console.WriteLine(output);

/*8. Write an expression that checks for a given point {x, y} if it is within 
the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of 
the circle and 5 is the radius.*/

/*9. Write an expression that checks for given point {x, y} if it is within the 
circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
Clarification: for the rectangle the lower left and the upper right corners 
are given.*/

/*10. Write a program that takes as input a four-digit number in format abcd
(e.g. 2011) and performs the following actions:
- Calculates the sum of the digits (in our example 2+0+1+1 = 4).
- Prints on the console the number in reversed order: dcba (in our 
example 1102).
- Puts the last digit in the first position: dabc (in our example 1201).
- Exchanges the second and the third digits: acbd (in our example 
2101).*/

Console.Write("Enter four digit numbernumber: ");
int integer5 = Convert.ToInt32(Console.ReadLine());

int first = integer5 / 1000;
int second = integer5 / 100 % 10;
int third = integer5 % 100 / 10;
int fourth = integer5 %  10;
Console.WriteLine(first+second+third+fourth);
Console.WriteLine($"{fourth} {third} {second} {first}");
Console.WriteLine($"{fourth} {first} {second} {third}");
Console.WriteLine($"{first} {third} {second} {fourth}");

/*11. We are given a number n and a position p. Write a sequence of 
operations that prints the value of the bit on the position p in the 
number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, 
p=6 -> 0.*/

/*12. Write a Boolean expression that checks if the bit on position p in the 
integer v has the value 1. Example v=5, p=1 -> false.*/
Console.WriteLine("Enter number");
string number = Console.ReadLine();
int p = Convert.ToInt32(Console.ReadLine());
int bit = number[p] - '0';
Console.WriteLine(bit); 

/*13. We are given the number n, the value v (v = 0 or 1) and the position p. 
write a sequence of operations that changes the value of n, so the bit on 
the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. 
Another example: n=35, p=2, v=1 -> n=39./*

/*14. Write a program that checks if a given number n (1 < n < 100) is a 
prime number (i.e. it is divisible without remainder only to itself and 1).*/

Console.Write("Enter number: ");
int x = Convert.ToInt32(Console.ReadLine());
int mainDivider = x * x;
if(mainDivider % 2 == 1) {
    Console.WriteLine("prime");
} else {
    Console.WriteLine("!prime");
}

/*15. * Write a program that exchanges the values of the bits on positions 
3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned 
integer.*/

/*16. * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, 
q+1, …, q+k-1} of a given 32-bit unsigned integer.*/
