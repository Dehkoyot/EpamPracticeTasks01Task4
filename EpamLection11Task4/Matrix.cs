using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLection11Task4
{
    public class Matrix
    {
        private int[,] mass;
        private int n, m;

        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            mass = new int[n, m];
        }

        public static Matrix MatrixInput()
        {
            Console.WriteLine("Type number of rows and colums:");
            Matrix mass = new Matrix(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            return mass;
        }

        public int this[int n, int m]
        {
            set
            {
                mass[n, m] = value;
            }
            get
            {
                return mass[n, m];
            }
        }

        public void Init()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) mass[i, j] += i + 1;
            }
        }

        public void Output()
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < n; i++)                     
            {
                for (int j = 0; j < m; j++)
                    Console.Write(mass[i, j].ToString() + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }




        public static Matrix operator -(Matrix mas, Matrix mas1)
        {
            var subtraction = new Matrix(mas.n, mas.m);
            try
            {
                for (int i = 0; i < subtraction.n; i++)
                {
                    for (int j = 0; j < subtraction.m; j++)
                    {
                        subtraction[i, j] = mas[i, j] - mas1[i, j];
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                if (mas.n != mas1.n || mas.m != mas1.m)
                    Console.WriteLine("Matrixes have got different sizes: " + e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return subtraction;
        }


        public static Matrix operator +(Matrix mas, Matrix mas1)
        {
            var addition = new Matrix(mas.n, mas.m);
            try
            {
                for (int i = 0; i < addition.n; i++)
                {
                    for (int j = 0; j < addition.m; j++)
                    {
                        addition[i, j] = mas[i, j] + mas1[i, j];
                    }
                }

            }
            catch (IndexOutOfRangeException e)
            {
                if (mas.n != mas1.n || mas.m != mas1.m)
                    Console.WriteLine("Matrixes have got different sizes: " + e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return addition;
        }

        public static Matrix operator *(Matrix mas, Matrix mas1)
        {
            var multi = new Matrix(mas.n, mas1.m);
            try
            {
                for (int i = 0; i < mas.n; ++i)
                {
                    for (int j = 0; j < mas1.m; ++j)
                    {
                        multi[i, j] = 0;
                        for (int k = 0; k < mas.m; ++k)
                        { 
                            multi[i, j] += mas[i, k] * mas1[k, j]; 
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return multi;
        }

        public static Matrix operator *(Matrix mas, int k)
        {
            var multiNum = new Matrix(mas.n, mas.m);
            try
            {
                for (int i = 0; i < multiNum.n; i++)
                {
                    for (int j = 0; j < multiNum.m; j++)
                    {
                        multiNum[i, j] = mas[i, j] * k;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
            return multiNum;
        }

        public Matrix Transpose()
        {
            var transposed = new Matrix(this.m, this.n);
            try
            {
                for (int i = 0; i < transposed.n; i++)
                {
                    for (int j = 0; j < transposed.m; j++)
                    {
                        transposed[i, j] = mass[j, i];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return transposed;
        }

        public Matrix Submatrix(int n, int m)
        {
            var sub = new Matrix(n, m);
            try
            {
                if (n > this.n || m > this.m)
                {
                    throw new Exception("Submatrix can't be greater than base matrix");
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        sub[i, j] = mass[i, j];
                    }
                }
            }
            catch (Exception ex)
            {
                if (n > this.n || m > this.m)
                    Console.WriteLine("Submatrix must be less then base one: " + ex.Message);
            }
            return sub;
        }

        public static bool Equals(Matrix mas, Matrix mas1)
        {
            try
            {
                for (int i = 0; i < mas.n; i++)
                {
                    for (int j = 0; j < mas.m; j++)
                    {
                        if (mas[i, j] != mas1[i, j]) return false;
                    }
                }
            
            }
            catch (IndexOutOfRangeException e)
            {
                if (mas.n != mas1.n || mas.m != mas1.m)
                    Console.WriteLine("Matrixes have got different sizes:" + e.Message);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
               
            }
            return true;

        }
    }
}
