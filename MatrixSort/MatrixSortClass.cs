using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSort
{
    public class MatrixSortClass
    {
        public enum Oder
        {
            DECREASE, INCREASE
        }

        //Sorts jagged array rows by max elements of rows
        public static void MatrixSortByMaxElement(ref int[][] matrix, Oder flag)
        {
            int rows = matrix.GetLength(0);
            for (int a = 0; a < rows - 1; a++)
            {
                for (int i = 0; i < rows - a - 1; i++)
                {
                    int maxI = matrix[i][0];
                    int maxI1 = matrix[i + 1][0];
                    for (int j = 1; j < matrix[i].Length; j++)
                    {
                        if (maxI < matrix[i][j])
                            maxI = matrix[i][j];
                    }
                    for (int j = 1; j < matrix[i + 1].Length; j++)
                    {
                        if (maxI1 < matrix[i + 1][j])
                            maxI1 = matrix[i + 1][j];
                    }
                    if (flag == Oder.DECREASE)
                    {
                        if (maxI < maxI1)
                        {
                            int[] tmp = matrix[i];
                            matrix[i] = matrix[i + 1];
                            matrix[i + 1] = tmp;
                        }
                    }
                    if (flag == Oder.INCREASE)
                    {
                        if (maxI > maxI1)
                        {
                            int[] tmp = matrix[i];
                            matrix[i] = matrix[i + 1];
                            matrix[i + 1] = tmp;
                        }
                    }
                }
            }
       }

        //Sorts jagged array rows by min elements of rows
        public static void MatrixSortByMinElement(ref int[][] matrix, Oder flag)
        {
            int rows = matrix.GetLength(0);
            for (int a = 0; a < rows - 1; a++)
            {
                for (int i = 0; i < rows - a - 1; i++)
                {
                    int minI = matrix[i][0];
                    int minI1 = matrix[i + 1][0];
                    for (int j = 1; j < matrix[i].Length; j++)
                    {
                        if (minI > matrix[i][j])
                            minI = matrix[i][j];
                    }
                    for (int j = 1; j < matrix[i + 1].Length; j++)
                    {
                        if (minI1 > matrix[i + 1][j])
                            minI1 = matrix[i + 1][j];
                    }
                    if (flag == Oder.DECREASE)
                    {
                        if (minI < minI1)
                        {
                            int[] tmp = matrix[i];
                            matrix[i] = matrix[i + 1];
                            matrix[i + 1] = tmp;
                        }
                    }
                    if (flag == Oder.INCREASE)
                    {
                        if (minI > minI1)
                        {
                            int[] tmp = matrix[i];
                            matrix[i] = matrix[i + 1];
                            matrix[i + 1] = tmp;
                        }
                    }
                }
            }
        }

        //Sorts jagged array rows by sum of rows elements
        public static void MatrixSortBySum(ref int[][] matrix, Oder flag)
        {
            int rows = matrix.GetLength(0);
            for (int a = 0; a < rows - 1; a++)
            {
                for (int i = 0; i < rows - a - 1; i++)
                {
                    int sumI = matrix[i][0];
                    int sumI1 = matrix[i + 1][0];
                    for (int j = 1; j < matrix[i].Length; j++)
                    {
                        sumI += matrix[i][j];
                    }
                    for (int j = 1; j < matrix[i + 1].Length; j++)
                    {
                            sumI1 = matrix[i + 1][j];
                    }
                    if (flag == Oder.DECREASE)
                    {
                        if (sumI < sumI1)
                        {
                            int[] tmp = matrix[i];
                            matrix[i] = matrix[i + 1];
                            matrix[i + 1] = tmp;
                        }
                    }
                    if (flag == Oder.INCREASE)
                    {
                        if (sumI > sumI1)
                        {
                            int[] tmp = matrix[i];
                            matrix[i] = matrix[i + 1];
                            matrix[i + 1] = tmp;
                        }
                    }
                }
            }
        }

    }
}
