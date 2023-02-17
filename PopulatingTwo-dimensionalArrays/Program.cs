using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PopulatingTwo_dimensionalArrays
{
    internal class Program
    {
        static List<string> Numbers()
        {
            List<string> numbers = new List<string>() { "01", "02", "03", "04", "05", "06", "07", "08",
                                                        "09", "10", "11", "12", "13", "14", "15", "16"};
            return numbers;
        }
        static void FillArrayByImage(string[,] array, List<string> numbers)
        {
            int Case0Index = 0;
            int Case1Index = 7;
            int Case2Index = 8;
            int Case3Index = 15;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    switch(j)
                    {
                        case 0:
                            array[i, j] = numbers[Case0Index];
                            Case0Index++;
                            break;

                        case 1:
                            array[i, j] = numbers[Case1Index];
                            Case1Index--;
                            break;

                        case 2:
                            array[i, j] = numbers[Case2Index];
                            Case2Index++;
                            break;

                        case 3:
                            array[i, j] = numbers[Case3Index];
                            Case3Index--;
                            break;
                    }
                    Console.Write(array[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            int lines = 4;
            int columns = 4;
            List<string> numbers = Numbers();
            string[,] array = new string[lines, columns];
            FillArrayByImage(array, numbers);
        }
        
    }
}

