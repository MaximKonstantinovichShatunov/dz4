/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/



void PrintArray(int[] Array)
{
    for (int i=0; i < 8 ; i++){

        Console.Write($"{Array[i]}");
    }
}

Console.WriteLine("Введите 8 чисел: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int number4 = Convert.ToInt32(Console.ReadLine());
int number5 = Convert.ToInt32(Console.ReadLine());
int number6 = Convert.ToInt32(Console.ReadLine());
int number7 = Convert.ToInt32(Console.ReadLine());
int number8 = Convert.ToInt32(Console.ReadLine());
int[] Arr= new int[] {number1, number2, number3, number4, number5,number6, number7, number8};

PrintArray(Arr);