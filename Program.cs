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


