// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int F = GetInt();
int S = GetInt();

int GetInt()
{
    System.Console.WriteLine("Введите целое число: ");
    int N = int.Parse(Console.ReadLine());
    return N;
}

int n = 0;
int res = 0;

for (n=1; n<=S; n++)
{
    res += F * F;
}

Console.WriteLine(res);


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Res(GetInt());

int GetInt()
{
    Console.WriteLine("Введите целое число: ");
    int N = int.Parse(Console.ReadLine());
    return N;
}

void Res(int dig)
{
    int result = 0;
    int one = 0;

    while(dig > 0)
    {
        one = dig % 10;
        result += one;
        dig = dig /10;
    }
    Console.WriteLine(result);
}

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] myArray = new int[8];
Random rand = new Random();

for (int i = 0; i < myArray.Length; i++)
      {
          myArray[i] = rand.Next(10);
          Console.WriteLine("Значение элемента массива " + i + " = " + myArray[i]);
      }
