using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson18_OverloadingOperators
{
    /// <summary>
    /// Use operators where they lend understanding and simplicity to a type. 
    /// Otherwise, do not use them.
    /// The syntax required to implement an overloaded operator is much the same as a static method with a couple exceptions. 
    /// You must use the operator keyword and specify the operator symbol being overloaded. 
    /// </summary>
    class Matrix
    {
        
        public const int DimSizeX = 3;
        public const int DimSizeY = 5;
        private double[,] m_matrix = new double[DimSizeX, DimSizeY];
        
        public double this[int x, int y]
        {
            get { return m_matrix[x, y]; }
            set { m_matrix[x, y] = value; }
            
        }    

        public static Matrix operator +(Matrix mat1, Matrix mat2)
        {
            /// <summary>
            /// Notice that the method is static. 
            /// Use the keyword operator after specifying the return type, 
            /// Matrix in this case. 
            /// Following the operator keyword, 
            /// the actual operator symbol is specified and then there is a set of parameters to be operated on.
            /// </summary>
            
            Matrix newMatrix = new Matrix();

            for (int x = 0; x < DimSizeX; x++)
                for (int y = 0; y < DimSizeY; y++)
                    newMatrix[x, y] = mat1[x, y] + mat2[x, y];

            return newMatrix;
        }

        public static void InitMatrix(Matrix mat)
        {
            for (int x = 0; x < Matrix.DimSizeX; x++)
                for (int y = 0; y < Matrix.DimSizeY; y++)
                    mat[x, y] = MatrixTest.m_rand.NextDouble();
        }

        public static void PrintMatrix(Matrix mat)
        {
            Console.WriteLine();
            for(int x=0; x<Matrix.DimSizeX; x++)
            {
                Console.Write("[");
                for(int y=0; y<Matrix.DimSizeY; y++)
                {
                    Console.Write("{0, 8:#.000000}", mat[x,y]);

                    if ((y+1%2)<3) Console.Write(",");
                }
                Console.WriteLine("]");
            }
            Console.WriteLine();
        }
    }
    /// C# enforces certain rules when you overload operators. 
    /// One rule is that you must implement the operator overload in the type that will use it. 
    /// This is sensible because it makes the type self-contained.
    /// Another rule is that you must implement matching operators.
    /// For example, if you overload ==, you must also implement !=. The same goes for <= and >=.
    /// When you implement an operator, its compound operator works also. 
    /// For example, since the + operator for the Matrix type was implemented, 
    /// you can also use the += operator on Matrix types.
}
