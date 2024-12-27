/*1. Write a program that prints on the console the numbers from 1 to N. 
The number N should be read from the standard input.
Console.Write("Enter number : ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++) {
    Console.WriteLine(i);
}
*/
/*2. Write a program that prints on the console the numbers from 1 to N, 
which are not divisible by 3 and 7 simultaneously. The number N 
should be read from the standard input. 
Console.Write("Enter number : ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= n; i++) {
    if (i % 3 == 0 && i % 7 == 0) {
        Console.WriteLine(i);
    } 
}*/

/*3. Write a program that reads from the console a series of integers and 
prints the smallest and largest of them.
Console.Write("Enter how many number you want to check : ");
int n = Convert.ToInt32(Console.ReadLine());
int greatest = 0;
int smallest = int.MaxValue;

for (int i = 1; i <= n; i++) {
    Console.Write($"Enter number {i} : ");
    int a = Convert.ToInt32(Console.ReadLine());


    if (a > greatest) {
        greatest = a;
    }
    if (a < smallest) {
        smallest = a;
    }
}
    Console.WriteLine($"The greatest is {greatest}");
    Console.WriteLine($"The smallest is {smallest}");*/

/*4. Write a program that prints all possible cards from a standard deck 
of cards, without jokers (there are 52 cards: 4 suits of 13 cards).
int suits = 4;
int cards = 13;
for (int a = 1; a <= suits; a++)
{
    for (int b = 1; b <= cards; b++)
    {
        Console.WriteLine($"{a} suit : {b} card");
    }
}*/

/*5. Write a program that reads from the console number N and print the sum 
of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
13, 21, 34, 55, 89, 144, 233, 377, … 
    Console.Write($"Enter number : ");
    int N = Convert.ToInt32(Console.ReadLine());
    
    //fibonacci sequence
    int a = 0;
    int b = 1;
    int add = a + b;
    Console.WriteLine($"{a}\n{b}");

    for (int i = 1; i <= N-2; i++) {
        int next = a + b;
        add += next;
        Console.WriteLine(next);
        a = b;
        b = next;
    }
    Console.WriteLine($"The result of first {N} is {add}");*/

/*6. Write a program that calculates N!/K! for given N and K (1<K<N).
    Console.Write("Enter N integer : ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter K integer : ");
    int K = Convert.ToInt32(Console.ReadLine());
    if (N > 1 && K > 1 && N > K) {
        //n!
        int Nall = 1;
        for (int i = 1; i <= N; i++) {
            Nall *= i;
        }
        //k!
        int Kall = 1;
        for (int b = 1; b <= K; b++) {
            Kall *= b;
        }

        int calculated = Math.Abs(Nall / Kall);
        Console.Write(calculated);
    } else {
        Console.WriteLine("Invalid input for N or K");
    }*/

/*7. Write a program that calculates N!*K!/(N-K)! for given N and K 
(1<K<N).

    Console.Write("Enter N integer : ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter K integer : ");
    int K = Convert.ToInt32(Console.ReadLine());
    
    if (N > 1 && K > 1 && N >= K) {
        //n!
        int Nall = 1;
        for (int i = 1; i <= N; i++) {
            Nall *= i;
        }
        //k!
        int Kall = 1;
        for (int i = 1; i <= K; i++) {
            Kall *= i;
        }
        //sub
        int NK = N - K;    
        int NKall = 1;
        for (int i = 1; i <= NK; i++) {
            NKall *= i;
        }

        int calculated = (Nall * Kall) / NKall;
        Console.Write(calculated);
    } else {
        Console.WriteLine("Invalid input for N or K");
    }*/

/*8. In combinatorics, the Catalan numbers are calculated by the following 
formula: for n ≥ 0. Write a program that 
calculates the nth Catalan number by given n. */

/*9. Write a program that for a given integers n and x, calculates the sum
    Console.Write("Enter N integer : ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter X integer : ");
    int X = Convert.ToInt32(Console.ReadLine());

    decimal greatSum = 1;
    
    //great loop
    for (int i = 1; i <= N; i++) {
        
        //factorial
        int factorial = 1;
        for(int j = 1; j <= i; j++) {
            factorial *= j;
        }

        //power
        int power = 1;
        for (int k = 1; k <= i; k++) {
            power *= X;
        }

        greatSum += (decimal)factorial/power;

        }
        Console.WriteLine(greatSum);*/



/*10. Write a program that reads from the console a positive integer number 
N (N < 20) and prints a matrix of numbers as on the figures below: 
         N = 3     N = 4 
        Console.Write("Enter N integer : ");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N > 0 && N < 20) {}
        for (int i = 1; i <= N; i++) {
            for (int j = 0; j < N; j++) {
                Console.Write(i + j );
            }
            Console.WriteLine();
        }
        }*/

/*11. Write a program that calculates with how many zeroes the factorial of 
a given number ends. Examples: 
N = 10 -> N! = 3628800 -> 2 
N = 20 -> N! = 2432902008176640000 -> 4 
Console.Write("Enter N integer : ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 0; 
for (int i = 5; i < N; i*=5) {
    count += N / i;
}
Console.WriteLine(count);*/
/*12. Write a program that converts a given number from decimal to binary 
notation (numeral system). 
13. Write a program that converts a given number from binary to decimal 
notation. 
14. Write a program that converts a given number from decimal to 
hexadecimal notation. 
15. Write a program that converts a given number from hexadecimal to 
decimal notation. 
16. Write a program that by a given integer N prints the numbers from 1 to N 
in random order. 
17. Write a program that given two numbers finds their greatest common 
divisor (GCD) and their least common multiple (LCM). You may use 
the formula LCM(a, b) = |a*b| / GCD(a, b). 
18. * Write a program that for a given number n, outputs a matrix in the 
form of a spiral: 
1 2 3 4 
Example for n=4: 
12 13 14 5 
11 16 15 6 
10 9 8 7*/
