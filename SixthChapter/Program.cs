/*1. Write a program, which creates an array of 20 elements of type 
integer and initializes each of the elements with a value equals to the 
index of the element multiplied by 5. Print the elements to the console.
int[] arr = new int[20];
for (int i = 0; i < arr.Length; i++) {
    arr[i] = i*5;
    Console.WriteLine(arr[i]);
}*/

/*2. Write a program, which reads two arrays from the console and checks 
whether they are equal (two arrays are equal when they are of equal 
length and all of their elements, which have the same index, are equal).
Console.Write("Enter length of arr one : ");
int arr1 = Convert.ToInt32(Console.ReadLine());
int[] ar1 = new int[arr1];

Console.Write("Enter length of arr two : ");
int arr2 = Convert.ToInt32(Console.ReadLine());
int[] ar2 = new int[arr2];

for (int i = 0; i < arr1; i++) {
    Console.Write($"Enter array index {i} : ");
    ar1[i] = Convert.ToInt32(Console.ReadLine());
}

for (int j = 0; j < arr2; j++) {
    Console.Write($"Enter array index {j} : ");
    ar2[j] = Convert.ToInt32(Console.ReadLine());
}
bool equal = false;
for (int z = 0; z < arr1; z++) {
    if (ar1.Length == ar2.Length && ar1[z] == ar2[z]) {
        equal = true;
    } else {
        equal = false;
    }
}
Console.WriteLine(equal);*/
/*3. Write a program, which compares two arrays of type char 
lexicographically (character by character) and checks, which one is first 
in the lexicographical order.
char[] chars1 = {'a', 'b', 'c', 'd'};
char[] chars2 = {'a', 'n', 'c', 'd'};
int smallest = Math.Min(chars1.Length, chars2.Length);
for (int i = 0; i < smallest; i++) {
    if (chars1[i] < chars2[i]) {
        Console.WriteLine("The first array comes first");
        return;
    } else 
    if(chars1[i] > chars2[i]) {
        Console.WriteLine("The second array comes first");
        return;
    } else {
        Console.WriteLine("They are equal");
        return;
    }
}*/

/*4. Write a program, which finds the maximal sequence of consecutive 
equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.
int[] arr = {1, 1, 2, 3, 2, 2, 2, 1};
int currentCount = 1;
int active = 0;
for (int i = 1; i < arr.Length-1; i++) {
    if (arr[i] == arr[i-1]) {
        currentCount++;
        active = arr[i];
    } else {
        currentCount = 1;
    }
}
Console.WriteLine($"we have {active} in {currentCount} places as the highest count");*/

/*5. Write a program, which finds the maximal sequence of consecutively 
placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
int[] seq = {3, 2, 3, 4, 2, 2, 4};
int count = 1;
for (int i = 1; i < seq.Length; i++) {
    if(seq[i] == seq[i-1] + 1) {
        count ++;
    }
}
Console.WriteLine(count);*/

/*6. Write a program, which finds the maximal sequence of increasing 
elements in an array arr[n]. It is not necessary the elements to be 
consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.*/

/*7. Write a program, which reads from the console two integer numbers N 
and K (K<N) and array of N integers. Find those K consecutive 
elements in the array, which have maximal sum. 
Console.Write("Enter integer N");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer K");
int K = Convert.ToInt32(Console.ReadLine());*/

/*8. Sorting an array means to arrange its elements in an increasing (or 
decreasing) order. Write a program, which sorts an array using the 
algorithm "selection sort".
int[] num = {2, 3, 4, 5};
int sort = Array.sort(num);
Console.WriteLine(sort);*/

/*9. Write a program, which finds a subsequence of numbers with 
maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11 *
int[] arr = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
int highest = 0;
for (int i = 0; i < arr.Length-3; i++) {
    int chek = arr[i] + arr[i+1] + arr[i+2] + arr[i+3];
    if (chek > highest) {
        highest = chek;
    }
}
Console.WriteLine(highest);*/

/*10. Write a program, which finds the most frequently occurring element in 
an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times).
int[] check = {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};
int Count = 0;
int eachCount = 0;
for (int i = 0; i < check.Length; i++) {
    for (int j = 0; j < check.Length; j++) {
        if (check[i] == check[j]) {
            eachCount++;
        }
    }
    if (eachCount > Count) {
        Count = eachCount;
        eachCount = 0;
    }
}
Console.WriteLine(Count);*/

/*11. Write a program to find a sequence of neighbor numbers in an array, 
which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8}, 
S=11  {4, 2, 5}. 
int NumberToChek = 11;
bool found = false;
int[] check = {4, 3, 1, 4, 2, 5, 8};
for (int i = 0; i < check.Length-2; i++) {
    int add = check[i] + check[i+1] + check[i+2];
    if (add == NumberToChek) {
        found = true;
    }
}
Console.WriteLine(found);*/

