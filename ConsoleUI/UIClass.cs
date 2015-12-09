using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixSort;

namespace ConsoleUIMatrix
{
    class UIClass
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[4][];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                int columns = rnd.Next(3, 7);
                jaggedArray[i] = new int[columns];
                for(int j = 0; j < columns; j++)
                    jaggedArray[i][j] = rnd.Next(-100, 100);
            }
            Console.WriteLine("Jagged array");
            Output(jaggedArray);
            Console.WriteLine("\nSort jagged array rows by max element in decrease order");
            MatrixSortClass.MatrixSortByMaxElement(ref jaggedArray, MatrixSortClass.Oder.DECREASE);
            Output(jaggedArray);
            Console.WriteLine("\nSort jagged array rows by min element in increase order");
            MatrixSortClass.MatrixSortByMinElement(ref jaggedArray, MatrixSortClass.Oder.INCREASE);
            Output(jaggedArray);
            Console.WriteLine("\nSort jagged array rows by sum of rows elements in decrease order");
            MatrixSortClass.MatrixSortBySum(ref jaggedArray, MatrixSortClass.Oder.DECREASE);
            Output(jaggedArray);
            Console.Read();
        }

        public static void Output(int [][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                    Console.Write(jaggedArray[i][j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
