using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Dimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of elements of the array: ");
            int Array_Element_Count = int.Parse(Console.ReadLine());
            double [] array = new double[Array_Element_Count];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a random number: ");
                double Random_Number = double.Parse(Console.ReadLine());
                array[i] = Random_Number;              
            }
            Console.WriteLine();
            Console.WriteLine("The array in reverse order:");
            for (int i = array.Length; i > 0; i--)
            {
                Console.Write(array[i - 1] + " ");
            }
        }
    }
}
