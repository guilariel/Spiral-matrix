using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = [[1]];



            SpiralOrder(matrix);

            Console.ReadLine();
        }
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> orden = new List<int>();

            int top = 0;
            int bottom = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;

            if (matrix.Length == 1)
            {
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    orden.Add(matrix[0][i]);
                    left++;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix.Length > 1 && matrix[i].Length == 1)
                {
                    orden.Add(matrix[i][0]);
                    top++;
                }
            }
            while (top <= bottom && left <= right)
            {
                for (int j = left; j <= right; j++)
                {
                    orden.Add(matrix[top][j]);
                }
                top++;  // Avanzamos la fila superior después de recorrer

                for (int j = top; j <= bottom; j++)
                {
                    orden.Add(matrix[j][right]);
                }
                right--;  // Reducimos la columna derecha después de recorrer

                // Validación extra: Verificamos que aún hay filas antes de recorrer de derecha a izquierda
                if (top <= bottom)
                {
                    for (int j = right; j >= left; j--)
                    {
                        orden.Add(matrix[bottom][j]);
                    }
                    bottom--;  // Reducimos la fila inferior después de recorrer
                }

                // Validación extra: Verificamos que aún hay columnas antes de recorrer de abajo hacia arriba
                if (left <= right)
                {
                    for (int j = bottom; j >= top; j--)
                    {
                        orden.Add(matrix[j][left]);
                    }
                    left++;  // Avanzamos la columna izquierda después de recorrer
                }
            }


            foreach (int i in orden)
            {
                Console.WriteLine(i);
            }

            return orden;
        }
    }
}
/*if(matrix.Length == 1 && matrix[0].Length == 1)
  {
      orden.Add(matrix[0][0]);
  }

  if (matrix.Length == 1 && matrix[0].Length != 1)
  {
      for (int i = 0; i <= matrix.Length; i++)
      {
          orden.Add(matrix[matrix.Length - 1][i]);
      }
  }

  for (int i = 0; i < matrix.Length; i++)
  {
      if (matrix[i].Length == 1 && matrix.Length > 1)
      {
          orden.Add(matrix[i][matrix[i].Length - 1]);
      }
  }*/


/*          for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix.Length != 1 && matrix[i].Length != 1)
                {
                    for (int j = i; j < matrix[i].Length - i; j++)
                    {
                        orden.Add(matrix[i][j]);
                    }

                    for (int j = i + 1; j < matrix.Length - i; j++)
                    {
                        orden.Add(matrix[j][matrix[i].Length - 1]);
                    }

                    for (int j = matrix[i].Length - 1 - i; 0 < j; j--)
                    {
                        orden.Add(matrix[matrix.Length - 1][j]);
                    }

                    for (int j = matrix.Length - 1 - i; 0 < j; j--)
                    {
                        orden.Add(matrix[j][i]);

                    }
                }
            }*/