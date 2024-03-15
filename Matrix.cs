using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*Створіть клас Matrix, який представляє цілочисельну матрицю. В цьому класі створіть:
    - Зубчастий двовимірний масив цілих чисел.
    - Індексатор для доступу до елементів матриці за допомогою індексів row та column.

Напишіть метод FillMatrixRandom(int rows, int columns, int min, int max), який заповнює матрицю випадковими числами в діапазоні від min до max.
Створіть об'єкт класу Matrix, заповніть його випадковими значеннями та виведіть матрицю на консоль. 
Потім, за допомогою індексатора, знайдіть та виведіть значення певного елемента матриці.*/

namespace Modul11
{
    internal class Matrix
    {
        private int[][] Array;
        public int Row { get; set; }
        public int Column { get; set; }

        public int GetElem(int row, int column)
        {
            return Array[row][column];
        }

        public void FillMatrixRandom(int rows, int columns, int min, int max)
        {
            int elem = 0;
            for (int i = 0; i <  rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    Array[i][j] = elem;
                    elem += 1;
                }
            }
        }

        public void DisplayMatrix()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Console.Write(Array[i][j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}

