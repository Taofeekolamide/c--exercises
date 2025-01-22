/*1. Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary 
numeral system.
Console.Write("Enter number : ");
int decimals = Convert.ToInt32(Console.ReadLine());

string binary = "";
for (int number = decimals; number > 0; number/=2) {
    int remainder = (number % 2);
    binary += remainder;
}
char[] chars = binary.ToCharArray();
for (int i = 0; i < chars.Length; i++) {
    Console.Write(chars[chars.Length - i - 1]);
}*/

/*2. Convert the number 1111010110011110(2) to hexadecimal and decimal 
numeral systems.
//decimal
Console.Write("Enter number : ");
string decimals = Console.ReadLine();
double decimalNumeral = 0;
for (int i = 0; i < decimals.Length; i++) {
    int current = decimals[i] - '0';
    decimalNumeral += (current * Math.Pow(2, decimals.Length-i-1));
}
Console.WriteLine(decimalNumeral);
//hexadecimal
int hex = (int)decimalNumeral;
Console.WriteLine($"{hex -10:X}");*/

/*3. Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and 
decimal numeral systems.
string hex = "FA";
//decimal
int decimaled = Convert.ToInt32(hex, 16);
//binary
String binaried = Convert.ToString(decimaled, 2);
Console.WriteLine(decimaled);
Console.WriteLine(binaried);*/

/*4. Write a program that converts a decimal number to binary one.
Console.Write("Enter Number : ");
int number = Convert.ToInt32(Console.ReadLine());
string binar = Convert.ToString(number, 2);
Console.Write(binar);*/

/*5. Write a program that converts a binary number to decimal one.
Console.Write("Enter Number in zero and one : ");
string number = Console.ReadLine();
int decim = Convert.ToInt32(number, 2);
Console.Write(decim);*/

/*6. Write a program that converts a decimal number to hexadecimal one.
Console.Write("Enter Number : ");
int number = Convert.ToInt32(Console.ReadLine());
string exes = Convert.ToString(number, 16);
Console.WriteLine(exes);*/

/*7. Write a program that converts a hexadecimal number to decimal one.
Console.Write("Enter Number in Hex : ");
string number = Console.ReadLine();
int hexes = Convert.ToInt32(number, 16);
Console.Write(hexes);*/

/*8. Write a program that converts a hexadecimal number to binary one.
Console.Write("Enter Number in Hex : ");
string number = Console.ReadLine();
int bines = Convert.ToInt32(number, 16);
string binary = Convert.ToString(bines, 2);
Console.Write(binary);*/

/*9. Write a program that converts a binary number to hexadecimal one.
Console.Write("Enter Number in binary : ");
string number = Console.ReadLine();
int binary = Convert.ToInt32(number, 2);
string bines = Convert.ToString(binary, 16);
Console.Write(bines);*/

/*10. Write a program that converts a binary number to decimal using the 
Horner scheme. 
string binary = "1001";
double ans = 0;
for (int i = 0; i < binary.Length; i++) {
    int a = binary[i]- '0';
    ans += a * Math.Pow(2, binary.Length-i-1);
}
Console.WriteLine(ans);*/

/*11. Write a program that converts Roman digits to Arabic ones.*/
/*12. Write a program that converts Arabic digits to Roman ones.*/
/*13. Write a program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number 
N from an S-based numeral system to a D based numeral system.*/ 
/*14. Try adding up 50,000,000 times the number 0.000001. Use a loop 
and addition (not direct multiplication). Try it with float and double and 
after that with decimal. Do you notice the huge difference in the 
results and speed of calculation? Explain what happens.*/ 
/*15. * Write a program that prints the value of the mantissa, the sign of the 
mantissa and exponent in float numbers (32-bit numbers with a 
floating-point according to the IEEE 754 standard). Example: for the 
number -27.25 should be printed: sign = 1, exponent = 10000011, 
mantissa = 10110100000000000000000.*/