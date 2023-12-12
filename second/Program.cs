// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.


  int[,] matrix = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int numRows = matrix.GetLength(0); // Получаем количество строк в матрице
        int numCols = matrix.GetLength(1); // Получаем количество столбцов в матрице

        for (int i = 0; i < numCols; i++) // Меняем местами первую и последнюю строки
        {
            int temp = matrix[0, i];
            matrix[0, i] = matrix[numRows - 1, i];
            matrix[numRows - 1, i] = temp;
        }

        for (int i = 0; i < numRows; i++) // Вывод перевёрнутой матрицы
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        
            