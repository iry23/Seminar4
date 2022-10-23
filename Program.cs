// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int AInNaturalDegreeB(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}

Console.Write("Input natural number A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input natural number B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int aInNaturalDegreeB = AInNaturalDegreeB(numA, numB);
Console.WriteLine(aInNaturalDegreeB);

//Задача 27: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (n > 0)
{
int num = n % 10;
n = n / 10;
sum = sum + num;
}
Console.WriteLine("The sum of digits in the number is " + sum);
*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов 
//и выводит их на экран.
//m = 5 -> [1, 2, 5, 7, 19]
//m = 3 -> [6, 1, 33]

//Эту задачу уже разбирали на семинаре? 
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);*/

