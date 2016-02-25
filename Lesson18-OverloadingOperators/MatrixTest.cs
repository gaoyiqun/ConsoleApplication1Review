using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson18_OverloadingOperators
{
    class MatrixTest
    {
        //used in the InitMatrix method
        public static Random m_rand = new Random();

        //test Matrix
        static void Main(string[] args)
        {
            Matrix mat1 = new Matrix();
            Matrix mat2 = new Matrix();

            Matrix.InitMatrix(mat1);
            Matrix.InitMatrix(mat2);

            Console.WriteLine("Matrix 1:");
            Matrix.PrintMatrix(mat1);
            Console.WriteLine("Matrix 2:");
            Matrix.PrintMatrix(mat2);

            Matrix mat3 = mat1 + mat2;
            Console.WriteLine();
            Console.WriteLine("Matrix 1+Matrix 2 = ");
            Matrix.PrintMatrix(mat3);

            Console.ReadLine();
        }
    }
}
