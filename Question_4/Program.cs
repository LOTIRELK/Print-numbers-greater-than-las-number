using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//a program that reads a list of 15 numbers and prints only those values that
//are greater than the last number in the list
namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[15];//declare int array of size 15
            Console.WriteLine("Please enter 15 positive numbers.");
            for (int i = 0; i < arr.Length; i++)//terminate after length of array reached
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());//assign the value entered to index in array
                
            }
            for (int i = 0; i < arr.Length; i++)//to scan array
            {
                int last = arr.Last();//declare integer given the value of the last number in the array
                if (arr[i] > arr.Last())//check if current number in array is greater than last number in array
                {
                    Console.Write(arr[i] +", ");//output the number
                }
            }
            
            Console.WriteLine();
        }
     }
}
