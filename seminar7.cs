// // Урок 7. Как не нужно писать код. Часть 1

// Console.WriteLine("Задача 47 \n" +
//                   "Задайте двумерный массив размером MxN \n" +
//                   "заполненный случайными вещественными числами \n" +
//                   "m = 3, n = 4. \n" +
//                   "0,5 7 -2 -0,2 \n" +
//                   "1 -3,3 8 -9,9 \n" +
//                   "8 7,8 -7,1 9 \n");

// Console.WriteLine("Решение:");

// double [,] FillArray ()
// {
//     Console.Write("Введите количество строк в массиве ");
//     int columnsArray = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите количество столбцов в массиве ");
//     int rowsArray = Convert.ToInt32(Console.ReadLine());

//     double [,] realNumbersArray = new double[columnsArray, rowsArray];

//     Random random = new Random();
//     for (int i = 0; i < columnsArray; i++)
//     {
//         for (int j = 0; j < rowsArray; j++)
//         {
//             realNumbersArray[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1                              
//         }

//     }
//     return realNumbersArray;      
    
// }

// void ShowArray(double[,] realNumbersArray)
// {
//     for (int i=0; i < realNumbersArray.GetLength(0); i++)    
//      {           
//         for (int j=0; j < realNumbersArray.GetLength(1); j++)
//         { 
//           Console.Write("{0,6:F2}", realNumbersArray[i, j]);          
//           Console.Write(" ");        
          
//         }
//         Console.WriteLine("");                                
        
//      }      
      
// }

// double [,] myArray = FillArray ();
// ShowArray(myArray);

// // Задача 47 --------Завершена ------------------------------------- 

// Console.WriteLine("Задача 50 \n" +
//                   "Напишите программу, которая \n" +
//                   "на вход принимает позиции элемента в двумерном массиве, \n" +
//                   "и возвращает значение этого элемента \n" +                  
//                   "или же указание, что такого элемента нет. \n" +
//                   "1 4 7 2 \n" +
//                   "5 9 2 3 \n" +
//                   "8 4 2 4 \n" +
//                   "17 -> числа с такими индексами в массиве нет \n");

// Console.WriteLine("Решение:");

// double [,] FillArray ()
// {
//     Random rd = new Random();
//     int rand_num = rd.Next(100,200);
//     int columnsArray = rd.Next(3,7);    
//     int rowsArray = rd.Next(2,5);

//     double [,] realNumbersArray = new double[columnsArray, rowsArray];

//     Random random = new Random();
//     for (int i = 0; i < columnsArray; i++)
//     {
//         for (int j = 0; j < rowsArray; j++)
//         {
//             realNumbersArray[i, j] = random.NextDouble() * 100;                              
//         }

//     }
//     return realNumbersArray;      
    
// }


// void ShowArray(double[,] realNumbersArray)
// {  

//     string desiredPosition ="Нет такой позиции в массиве ";

//     Console.Write("Введите искомую строку массива ");
//     int searchRow = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите искомый столбец массива ");
//     int searchColumn = Convert.ToInt32(Console.ReadLine());

//     for (int i=0; i < realNumbersArray.GetLength(0); i++)    
//      {           
//         for (int j=0; j < realNumbersArray.GetLength(1); j++)
//         {  

//          if (i == searchRow && j == searchColumn)
//            {
//               desiredPosition = "Искомая позиция содержит значение " 
//                                  + Math.Round(realNumbersArray[i, j], 2); 
//            }             


//           Console.Write("{0,6:F2}", realNumbersArray[i, j]);          
//           Console.Write(" ");             
//         }



//            Console.WriteLine("");                                                   
                                        
//      }   

//      Console.WriteLine(desiredPosition);
      
// }


// double [,] myArray = FillArray ();
// ShowArray(myArray);

// // Задача 50 --------Завершена ------------------------------------- 


// Console.WriteLine("Задача 52 \n" +
//                    "Задайте двумерный массив из целых чисел. \n" +
//                    "Найдите среднее арифметическое элементов в каждом столбце. \n" +
//                    "1 4 7 2 \n" +
//                    "5 9 2 3 \n" +
//                    "8 4 2 4 \n" +
//                    "Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. \n");

// Console.WriteLine("Решение:");

// int [,] FillArray ()
// {
//     Console.Write("Введите количество строк в массиве ");
//     int columnsArray = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите количество столбцов в массиве ");
//     int rowsArray = Convert.ToInt32(Console.ReadLine());

//     int [,] realNumbersArray = new int[columnsArray, rowsArray];

//     Random random = new Random();
    
//     for (int i = 0; i < columnsArray; i++)
//     {
//         for (int j = 0; j < rowsArray; j++)
//         {
//             realNumbersArray[i, j] = random.Next(0 , 10);                              
             
//         }

//     }
//     return realNumbersArray;         
    
// }

// void ShowArray(int[,] realNumbersArray)
// {
//     string temp = "";    
//     double temp2 = 0;

//     for (int i=0; i < realNumbersArray.GetLength(0); i++)    

//      {  
//         for (int j=0; j < realNumbersArray.GetLength(1); j++)
//         { 
          
//           Console.Write(realNumbersArray[i, j]);
//           Console.Write(" ");                          
                                     
//         }

//         Console.WriteLine();                         

//      }

//         Console.WriteLine("---------");      
//         Console.Write("Среднее арифметическое каждого столбца: ");


//   for (int i=0; i < realNumbersArray.GetLength(1); i++)    

//      {  
//         for (int j=0; j < realNumbersArray.GetLength(0); j++)
//         { 
          
         
//           temp2 = temp2 + (realNumbersArray[j, i]);                
                                     
//         }
        
//         temp2 = temp2 / realNumbersArray.GetLength(0);
//         temp2 = Math.Round(temp2, 2);
//         temp += Convert.ToString(temp2 + "; ");                     
//         temp2 = 0;               

//      }
      
//      Console.WriteLine(temp);                    
                
// }


// int [,] myArray = FillArray ();
// ShowArray(myArray);
