using System;
using System.Collections.Generic;
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
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            array[i, j] = numbers[0];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 1)
                        {
                            array[i, j] = numbers[7];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 2)
                        {
                            array[i, j] = numbers[8];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 3)
                        {
                            array[i, j] = numbers[15];
                            Console.Write(array[i, j] + " ");
                        }
                    }

                    if (i == 1)
                    {
                        if (j == 0)
                        {
                            array[i, j] = numbers[1];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 1)
                        {
                            array[i, j] = numbers[6];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 2)
                        {
                            array[i, j] = numbers[9];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 3)
                        {
                            array[i, j] = numbers[14];
                            Console.Write(array[i, j] + " ");
                        }
                    }

                    if (i == 2)
                    {
                        if (j == 0)
                        {
                            array[i, j] = numbers[2];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 1)
                        {
                            array[i, j] = numbers[5];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 2)
                        {
                            array[i, j] = numbers[10];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 3)
                        {
                            array[i, j] = numbers[13];
                            Console.Write(array[i, j] + " ");
                        }
                    }

                    if (i == 3)
                    {
                        if (j == 0)
                        {
                            array[i, j] = numbers[3];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 1)
                        {
                            array[i, j] = numbers[4];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 2)
                        {
                            array[i, j] = numbers[11];
                            Console.Write(array[i, j] + " ");
                        }

                        if (j == 3)
                        {
                            array[i, j] = numbers[12];
                            Console.Write(array[i, j] + " ");
                        }
                    }
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

