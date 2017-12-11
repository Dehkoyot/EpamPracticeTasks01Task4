using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLection11Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var mas = Matrix.MatrixInput();
            var mas1 = Matrix.MatrixInput();

            //initialization and output of matrix
            mas.Init();
            mas.Output();

            //initialization and output of matrix
            mas1.Init();
            mas1.Output();

            //Addition of Matrixes
            Console.WriteLine("Addition result:");
            (mas + mas1).Output();

            //Substraction of Matrixes
            Console.WriteLine("Substraction result:");
            (mas - mas1).Output();

            //Product of Matrixes
            Console.WriteLine("Product of matrixes:");
            (mas * mas1).Output();

            //Product of Matrix and number
            Console.WriteLine("Product of Matrix and number");
            (mas * 2).Output();

            //Building submatrix
            Console.WriteLine("Submatrix:");
            (mas.Submatrix(2, 2)).Output();

            //Transposed matrix
            Console.WriteLine("Transposed:");
            (mas.Transpose()).Output();

            //If matrixes are equal
            Console.WriteLine("Matrixes are Equal: {0}",(Matrix.Equals(mas, mas1)).ToString());

            Console.ReadKey();
        }
    }
}
