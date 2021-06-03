using System;

namespace All_Programs
{
  public static class ArrayDeclaration
  {
    public static void Run()
    {
      //
      // Single Array Declaration
      //
      // Declare a single-dimensional array of 5 integers.
      int[] array1 = new int[5];

      // Declare and set array element values.
      int[] array2 = new int[] { 1, 3, 5, 7, 9 };

      // Alternative syntax.
      int[] array3 = { 1, 2, 3, 4, 5, 6 };



      //
      // MultiDimensional Array Declaration
      //
      // Declare a two dimensional array.
      int[,] multiDimensionalArray1 = new int[2, 3];

      // Declare and set array element values.
      int[,] multiDimensionalArray2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

      // Alternative syntax.
      int[,] multiDimensionalArray3 = { { 1, 2, 3 }, { 4, 5, 6 } };



      //
      // Jagged Array Declaration
      //

      // Declare a jagged array.
      int[][] jaggedArray1 = new int[3][];
      jaggedArray1[0] = new int[5];
      jaggedArray1[1] = new int[] { 1, 2, 3, 4 };
      //jaggedArray1[2] = { 1, 2, 3 };  --  Not Valid

      // Declare and set array element values.
      int[][] jaggedArray2 = new int[][]
                             {
                               new int[] { 1, 3, 5, 7, 9 },
                               new int[] { 0, 2, 4, 6 },
                               new int[] { 11, 22 }
                             };

      // Alternative syntax.
      int[][] jaggedArray3 = { 
                               new int[] { 1, 2, 3, 4, 5 },
                               new int[] { 1, 2, 3, 4 },
                               new int[] { 1, 2, 3 }
                             };


      //
      // Multidimensional & Jagged Mixed Array Declaration
      //
      // Declare a jagged multidimensinal array.
      int[][,] multiJaggedArray1 = new int[5][,];

      // Declare and set array element values.
      int[][,] multiJaggedArray2 = new int[][,]
      {
        new int[,] { {1, 2, 3, 4 }, { 1, 2, 3, 4 } },
        new int[,] { {1, 2, 3 }, { 1, 2, 3 } }
      };



    }
  }
}
