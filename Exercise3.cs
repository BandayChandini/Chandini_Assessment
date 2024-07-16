using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ChandiniAssessment1
{
    /*Write a program to create a class called Car with Model, Year of making details. 
  
Read the Car details from the User and store into a file.
    */

    class Car
    {

        public string Model;
        public DateTime yearOfMaking;
        public void Details(string Model,DateTime yearOfMaking)
        {
            Console.WriteLine("Enter car Model: ");
            Console.WriteLine(Console.ReadLine());
            Console.WriteLine("Enter year of Making:");
            Console.WriteLine(Convert.ToDateTime(Console.ReadLine()));
            
        }

    }
    class FileInfo
    {

    }
    
    internal class Exercise3
    {
        static void Main()
        {
            try
            {
                Car obj = new Car();
                obj.Model = "Hyundai";
                obj.yearOfMaking = new DateTime(2002 / 04 / 27);
                obj.Details(Console.ReadLine(), Convert.ToDateTime(Console.ReadLine()));
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
