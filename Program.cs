using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyConsloe1

{
    class Array
    {
        //1
        static void SD_array()
        {
            float[] fl_arr = new float[5];
            for (int i = 0; i < fl_arr.Length; i++)
            {
                System.Console.Write("Enter the number {0}:", i + 1);
                fl_arr[i] = float.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Float arrays: ");
            foreach (float num in fl_arr)
            {
                System.Console.Write("\t" + num);
            }
        }

        //2
        static void Rectangular_arr()
        {
            int x = 10;
            int[,] rect_arr = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    rect_arr[i, j] = x++;
                }
            }
            System.Console.WriteLine("Rectangular Array: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    System.Console.Write(rect_arr[i, j] + "\t");
                }
                System.Console.WriteLine();
            }
        }

        //3
        static void jagged_array()
        {
            int x = 10;
            int[][] jag_array = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                jag_array[i] = new int[i + 1];
                for (int j = 0; j < jag_array[i].Length; j++)
                {
                    jag_array[i][j] = x++;
                }
            }
            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jag_array[i].Length; j++)
                {
                    Console.Write(jag_array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Int_arr()
        {
            //Allow user enter data for elements of the array
            System.Console.Write("you want the number of elements in the array 1 to be: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] int_arr = new int[length];
            System.Console.WriteLine("--Please enter integer number in array-- ");
            for (int i = 0; i < int_arr.Length; i++)
            {
                System.Console.Write($"Enter the int_arr[{i}]:");
                int_arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Display the array
            System.Console.WriteLine("the array just entered are: ");
            foreach (int item in int_arr)
            {
                System.Console.Write(item + "\t");
            }
            System.Console.WriteLine();
            //Display the average of the array
            float sum = 0;
            foreach (int item in int_arr)
            {
                sum = sum + item;
            }
            System.Console.WriteLine("The average value of the array is: {0}", sum / int_arr.Length);

            //Allow user enter an integer number x. How many times  does the number x appear in the array?
            int count = 0, find;

            System.Console.WriteLine("Please enter the number you want to find: ");
            find = Convert.ToInt32(Console.ReadLine());
            foreach (int item in int_arr)
            {
                if (item == find)
                {
                    count++;
                }
            }
            System.Console.WriteLine($"Number {find} appear {count} times!");

            //Replace the number x in the above question by 100. 
            System.Console.WriteLine("Replace the number x in the above by 100 and print out new array: ");
            for (int i = 0; i < int_arr.Length; i++)
            {
                if (int_arr[i] == find)
                {
                    int_arr[i] = 100;
                    System.Console.Write(int_arr[i] + "\t");
                }
                else
                {
                    System.Console.Write(int_arr[i] + "\t");
                }
            }

            //Display the prime numbers in the array
            System.Console.WriteLine();
            System.Console.Write("the prime numbers in the array is ");
            int cnt_snt = 0;
            for (int i = 0; i < int_arr.Length; ++i)
            {
                bool IsPrime = true;
                int number = int_arr[i];
                if (number < 2)
                {
                    IsPrime = false;
                }
                for (int j = 2; j * j <= number; j++)
                {
                    if (number % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    System.Console.Write(number + "\t");
                    ++cnt_snt;
                }
            }
            if (cnt_snt == 0) System.Console.Write("Nothing!!");
            System.Console.WriteLine("");

            //Enter a new array
            System.Console.Write("you want the number of elements in the array 2 to be: ");
            int length2 = Convert.ToInt32(Console.ReadLine());
            int[] int_arr2 = new int[length2];
            System.Console.WriteLine("--Please enter integer number in array 2-- ");
            for (int i = 0; i < int_arr.Length; i++)
            {
                System.Console.Write($"Enter the int_arr2[{i}]:");
                int_arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Find the elements that appears in two arrays.
            FindNumberAppear2Array(int_arr, int_arr2);
            static void FindNumberAppear2Array(int[] arr, int[] arr1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr1.Length; j++)
                    {
                        if (arr[i] == arr1[j])
                        {
                            System.Console.Write(arr[i] + "\t");
                        }
                    }
                }
                System.Console.WriteLine();
            }
            // int[] arr_tmp = new int[length + 2]; int num_tmp = 0;
            // Console.Write("Elements that appear in 2 array: ");
            // for (int i = length - 1; i >= 0; --i)
            // {
            //     if (match(int_arr2, int_arr[i]) && !match(arr_tmp, int_arr[i]))
            //     {
            //         arr_tmp[++num_tmp] = int_arr[i];
            //         Console.Write($"\t{int_arr[i]}]");
            //     }
            // }

            // int[] arr_notRepeat = new int[length + length2]; int num_notRepeat = 0;
            // Console.WriteLine("\n\nElements that appear in array 1 but not array 2: ");
            // for (int i = length - 1; i >= 0; i--)
            // {
            //     if (!match(arr_tmp, int_arr[i]) && !match(arr_notRepeat, int_arr[i]))
            //     {
            //         arr_notRepeat[++num_notRepeat] = int_arr[i];
            //         Console.Write($"\t{int_arr[i]}");
            //     }
            // }

            // int[] combineArray = new int[length + length2];
            // Array.Copy(int_arr, combineArray, length);
            // Array.Copy(int_arr2, 0, combineArray, length, length2);
            // Console.WriteLine("\n\nNew array merge: ");
            // foreach (int v in combineArray)
            // {
            //     Console.Write($"\t{v}");
            // }




            static void Main(string[] args)
            {
                SD_array();
                Rectangular_arr();
                jagged_array();
                Int_arr();
            }
        }
    }
}
