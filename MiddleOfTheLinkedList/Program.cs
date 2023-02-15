using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiddleOfLinkedList
{
    internal class Program
    {
        static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
        }

        static string GetArrayInString(int[] array)
        {
            return string.Join(",", array);
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine(GetArrayInString(array));
        }

        static void MiddleOfLinkedList(int[] array)
        {
            int i = 1;
            i = array.Length / 2;
            for (; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[12];
            FillArray(array);
            PrintArray(array);
            MiddleOfLinkedList(array);
        }
    }
}
