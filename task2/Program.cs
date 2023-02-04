﻿// Задайте двумерный массив размера m на n, каждый элемент в массиве 
//находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.


int[,] NumbersArray(int m = 3, int n = 4)
{
  int[,] array = new int[m, n];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = i + j;
    }
  }
  return array;
}
void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + "\t");
    }
  }
  Console.WriteLine();
}
PrintArray(NumbersArray(m: 3, n: 4));