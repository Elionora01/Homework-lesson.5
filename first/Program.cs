
//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

 int product = 1;// для заполнения от 1 до ...
            int[,] arr = new int[5, 4];// размер 5 на 4; строк 5 столбцов 4
            // заполним массив и выведем
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = product++;
                    Console.Write($"{arr[i, j],3}");// выводим массив
                }
                Console.WriteLine();
            }
            // начинаем искать
            Console.Write("Какую строку будем искать ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какой столбец будем искать ");
            int c = Convert.ToInt32(Console.ReadLine());
            // проверим условием границы 
            if (l <= arr.GetLength(0) - 1 && c <= arr.GetLength(1) - 1)
                Console.WriteLine("Элемент массива " + arr[l, c]);
            else
                Console.WriteLine("Такого элемента нет");
                
