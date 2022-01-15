﻿//Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
//Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(int[] Array1)

{
    for (int i = 0; i < Array1.Length; i++)
    {
        Array1[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] Array2)
{
    for (int j = 1; j < Array2.Length; j++)
    {
        Console.Write(Array2[j] + " ");
    }
}
int[] SelectEvenElements(int[] ArrayInitial)

{
    int j = 1;
    int[] ArrayInterim = new int[ArrayInitial.Length];

    for (int i = 1; i < ArrayInitial.Length; i++)
    {
        if (ArrayInitial[i] % 2 == 0)
        {
            ArrayInterim[j] = ArrayInitial[i];
            j++;
        }
    }

    int[] ArrayResult = new int[j];
    
    for (int k = 1; k < j; k++)
    {
        ArrayResult[k] = ArrayInterim[k];
    }

    return ArrayResult;
}
int[] ArrayInitial = new int[10];

Console.WriteLine("Original array is: ");
FillArray(ArrayInitial);
PrintArray(ArrayInitial);

Console.WriteLine();
Console.WriteLine("Array with even elements only is: ");
int[] ArrayResult = SelectEvenElements(ArrayInitial);
PrintArray(ArrayResult);
