// See https://aka.ms/new-console-template for more information
// Exercise One

using Session_05;

string input = "Giorgos";
char[] charArray = input.ToCharArray();
Array.Reverse(charArray);
string reversed = new string(charArray);
Console.WriteLine(reversed);

//Exercise Two

int n;
int choice;
int result = 1;
int sum = 0;
Console.WriteLine("Enter an integer: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 1 to compute the sum, or 2 to compute the product of 1 to n: ");
choice = int.Parse(Console.ReadLine());
if (choice == 1)
{
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    Console.WriteLine("The sum of 1 to " + n + " is: " + sum);
}
else if (choice == 2)
{
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    Console.WriteLine("The product of 1 to " + n + " is: " + result);
}
else
{
    Console.WriteLine("Invalid choice.");
}


//Exercise Three

int m;
Console.WriteLine("Enter a positive integer: ");
m = int.Parse(Console.ReadLine());

PrimeNumberFinder primeNumberFinder = new PrimeNumberFinder();
primeNumberFinder.FindPrimes(m);


// Exercise Four

int[] array1 = new int[] { 2, 4, 9, 12 };
int[] array2 = new int[] { 1, 3, 7, 10 };
Multiplier multiplier = new Multiplier();
int[] results = multiplier.MultiplyArrays(array1, array2);

Console.Write("The result of multiplying the two arrays is: [ ");
for (int l = 0; l < results.Length; l++)
{
    Console.Write(results[l] + " ");
}
Console.WriteLine("]");


// Exercise Five

int[] array = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
int temp;
for (int q = 0; q < array.Length; q++)
{
    for (int r = q + 1; r < array.Length; r++)
    {
        if (array[q] > array[r])
        {
            temp = array[q];
            array[q] = array[r];
            array[r] = temp;
        }
    }
}

Console.Write("The sorted array is: [ ");
for (int q = 0; q < array.Length; q++)
{
    Console.Write(array[q] + " ");
}
Console.Write("]");