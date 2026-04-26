using System;

public class Lab1
{
    public static char[,] MultiplyMatrix(char[,] matrix, char a)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        char[,] result = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = (char)(matrix[i, j] * a);
            }
        }
        return result;
    }
    
    public static char[] FindMinInColumns(char[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        char[] mins = new char[cols];

        for (int j = 0; j < cols; j++)
        {
            char minInCol = matrix[0, j];
            for (int i = 1; i < rows; i++)
            {
                if (matrix[i, j] < minInCol)
                {
                    minInCol = matrix[i, j];
                }
            }
            mins[j] = minInCol;
        }
        return mins;
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        try
        {
            char a = (char)2;
            char[,] b = {
                { (char)10, (char)20, (char)30 },
                { (char)15, (char)5,  (char)25 },
                { (char)8,  (char)12, (char)18 }
            };

            char[,] C = MultiplyMatrix(b, a);

            Console.WriteLine("Результуюча матриця C:");
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write((int)C[i, j] + "\t");
                }
                Console.WriteLine();
            }

            char[] mins = FindMinInColumns(C);
            long sumOfMins = 0;

            Console.WriteLine("\nНайменші елементи по стовпцях:");
            for (int j = 0; j < mins.Length; j++)
            {
                Console.WriteLine($"Стовпець {j + 1}: {(int)mins[j]}");
                sumOfMins += mins[j];
            }
            Console.WriteLine($"\nЗагальна сума найменших елементів: {sumOfMins}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}