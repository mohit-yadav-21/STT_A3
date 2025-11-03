using System;

class ArrayOperations
{
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = 0; j < arr.Length - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    static int[] RowMajor(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        int[] result = new int[rows * cols];
        int k = 0;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[k++] = arr[i, j];
        return result;
    }

    static int[] ColumnMajor(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        int[] result = new int[rows * cols];
        int k = 0;
        for (int j = 0; j < cols; j++)
            for (int i = 0; i < rows; i++)
                result[k++] = arr[i, j];
        return result;
    }

    static int[,] MatrixMultiply(int[,] A, int[,] B)
    {
        int r1 = A.GetLength(0);
        int c1 = A.GetLength(1);
        int r2 = B.GetLength(0);
        int c2 = B.GetLength(1);
        if (c1 != r2) throw new Exception("Invalid matrix dimensions");
        int[,] C = new int[r1, c2];
        for (int i = 0; i < r1; i++)
            for (int j = 0; j < c2; j++)
                for (int k = 0; k < c1; k++)
                    C[i, j] += A[i, k] * B[k, j];
        return C;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var x in arr) Console.Write(x + " ");
        Console.WriteLine();
    }

    static void PrintMatrix(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
                Console.Write(mat[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[] arr = { 5, 3, 8, 4, 2 };
        BubbleSort(arr);
        Console.WriteLine("Sorted Array:");
        PrintArray(arr);

        int[,] array2D = { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine("Row Major:");
        PrintArray(RowMajor(array2D));
        Console.WriteLine("Column Major:");
        PrintArray(ColumnMajor(array2D));

        int[,] A = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] B = { { 7, 8 }, { 9, 10 }, { 11, 12 } };
        int[,] C = MatrixMultiply(A, B);
        Console.WriteLine("Matrix Multiplication Result:");
        PrintMatrix(C);
    }
}
