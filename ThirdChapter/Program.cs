/*1. Write a program that reads from the console three numbers of type int
and prints their sum.*/
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstNumber = number / 100;
int secondNumber = number % 100 / 10;
int thirdNumber = number % 10;
Console.WriteLine($"{firstNumber + secondNumber+ thirdNumber}");

/*2. Write a program that reads from the console the radius "r" of a circle
and prints its perimeter and area.*/
Console.Write("Enter your radius: ");
double radius = Convert.ToDouble(Console.ReadLine());
//perimeter pi*r
double perimeter = Math.PI * radius;
Console.WriteLine($"the perimeter of a circle with the radius {radius} is {perimeter}");
//area 2*pi*r
double area = 2 * Math.PI * radius;
Console.WriteLine($"the area of a circle with the radius {radius} is {area}");

/*3. A given company has name, address, phone number, fax number, web
site and manager. The manager has name, surname and phone number.
Write a program that reads information about the company and its
manager and then prints it on the console.*/
Console.Write("Enter your company name: ");
string companyName = Console.ReadLine();

Console.Write("Enter company address: ");
string address = Console.ReadLine();

Console.Write("Enter company phone number: ");
string phoneNumber = Console.ReadLine();

Console.Write("Enter company fax number: ");
string faxNumber = Console.ReadLine();

Console.Write("Enter company website: ");
string website = Console.ReadLine();

Console.Write("Enter manager name: ");
string managerName = Console.ReadLine();

Console.Write("Enter manager number: ");
string managerNumber = Console.ReadLine();

Console.WriteLine($"Company information includes: \n Company name: {companyName},\n Company address: {address},\n Company phone number: {phoneNumber},\n Company fax number: {faxNumber}\n Company website: {website}");
Console.WriteLine($"Manager information inclues: \n Manager name: {managerName},\n Manager number: {managerNumber}");

/*4. Write a program that prints three numbers in three virtual columns
on the console. Each column should have a width of 10 characters and
the numbers should be left aligned. The first number should be an
integer in hexadecimal; the second should be fractional positive; and
the third – a negative fraction. The last two numbers have to be
rounded to the second decimal place.*/

Console.Write("Enter int one: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter int two: ");
double two = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter int three: ");
double three = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{one,-10:X} {two,-10:F2} {three,-10:F2}");


/*5. Write a program that reads from the console two integer numbers (int)
and prints how many numbers between them exist, such that the
remainder of their division by 5 is 0. Example: in the range (14, 25)
there are 3 such numbers: 15, 20 and 25.*/

Console.Write("Enter integer one: ");
int ones = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer two: ");
int twos = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = ones; i <= twos; i++) {
    if (i % 5 == 0) {
        result += 1;
    }
}
Console.WriteLine(result);

/*6. Write a program that reads two numbers from the console and prints the
greater of them. Solve the problem without using conditional
statements.*/
Console.Write("Enter integer one: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer two: ");
int z = Convert.ToInt32(Console.ReadLine());
bool greater = y > z;
Console.Write(greater);

/*7. Write a program that reads five integer numbers and prints their
sum. If an invalid number is entered the program should prompt the user
to enter another number.*/
Console.Write("Enter integer one: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer two: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer three: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer four: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer five: ");
int e = Convert.ToInt32(Console.ReadLine());

Console.Write($"the result is {a+b+c+d+e}");

/*8. Write a program that reads five numbers from the console and prints the
greatest of them.*/
Console.Write("Enter integer one: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer two: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer three: ");
int h = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer four: ");
int o = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer five: ");
int p = Convert.ToInt32(Console.ReadLine());

int greatest = m;
if(n > greatest) {
    greatest = n;
}
if(h > greatest) {
    greatest = h;
}
if (o > greatest) {
    greatest = o;
}
if(p > greatest) {
    greatest = p;
}
Console.WriteLine($"The greatest is integer one {greatest}");

/*9. Write a program that reads an integer number n from the console. After
that reads n numbers from the console and prints their sum.*/
Console.Write("Enter integer n: ");
int M = Convert.ToInt32(Console.ReadLine());
int total = 0;
for (int i = 0; i < M; i++) {
    Console.Write("Enter integer x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    total += x;
}
Console.Write(total);

/*10. Write a program that reads an integer number n from the console and
prints all numbers in the range [1…n], each on a separate line.*/
Console.Write("Enter integer n: ");
int on = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= on; i++) {
    Console.WriteLine(i);
}

/*11. Write a program that prints on the console the first 100 numbers in the
Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …*/
int ax = 0;
int bx = 1;

Console.WriteLine($"{ax}\n{bx}");
for (int i = 2; i < 98; i++) {
    int next = ax+bx;
    Console.WriteLine(next);
    ax = bx;
    bx = next;
}

/*12. Write a program that calculates the sum (with precision of 0.001) of
the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …*/