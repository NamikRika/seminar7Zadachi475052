// Урок 7. Как не нужно писать код. Часть 1

// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Задача 47 \n" +
                  "Задайте двумерный массив размером MxN \n" +
                  "заполненный случайными вещественными числами \n" +
                  "m = 3, n = 4. \n" +
                  "0,5 7 -2 -0,2 \n" +
                  "1 -3,3 8 -9,9 \n" +
                  "8 7,8 -7,1 9 \n");

Console.WriteLine("Решение:");

double [,] FillArray ()
{
    Console.Write("Введите количество строк в массиве ");
    int columnsArray = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов в массиве ");
    int rowsArray = Convert.ToInt32(Console.ReadLine());

    double [,] realNumbersArray = new double[columnsArray, rowsArray];

    Random random = new Random();
    for (int i = 0; i < columnsArray; i++)
    {
        for (int j = 0; j < rowsArray; j++)
        {
            realNumbersArray[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1                              
        }

    }
    return realNumbersArray;      
    
}

void ShowArray(double[,] realNumbersArray)
{
    for (int i=0; i < realNumbersArray.GetLength(0); i++)    
     {           
        for (int j=0; j < realNumbersArray.GetLength(1); j++)
        { 
          Console.Write("{0,6:F2}", realNumbersArray[i, j]);          
          Console.Write(" ");        
          
        }
        Console.WriteLine("");                                
        
     }      
      
}

double [,] myArray = FillArray ();
ShowArray(myArray);



// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.