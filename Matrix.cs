using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Реализуйте класс "Matrix", представляющий двумерную матрицу.
//Реализуйте индексатор, который позволяет получать и задавать элементы матрицы по индексу строки и столбца.
//Создайте объект типа "Matrix" и заполните его элементами. Затем выведите некоторые элементы матрицы, используя индексатор.
namespace Matrix1
{
    class Matrix
    {
        private int[,] matrix; 

        public Matrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
        }

        
        public int this[int row, int column]
        {
            get { return matrix[row, column]; }
            set { matrix[row, column] = value; }
        }
    }

   

}
