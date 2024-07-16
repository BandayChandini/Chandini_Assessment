using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ChandiniAssessment1
{
    /*Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix*/
    internal class Exercise2
    {
        


        static void Main()
        {
            int[,] matrix = new int[3, 3];
            try
            {
                
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine("Enter the Elements: ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(matrix[i, j]);
                    }

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

    }
}
