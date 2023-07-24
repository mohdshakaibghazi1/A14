using System;
using System.Diagnostics;
using System.Runtime.Remoting.Services;

namespace ConAppBubbleSort
{
    internal class Program
    {
        public static void insertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        //public static int[] arrayip()
        //{
        //    Console.WriteLine("enter length of the array");
        //    int len;
        //    len = int.Parse(Console.ReadLine());
        //    int[] arr = new int[len];
        //    Console.WriteLine("enter array items");
        //    for (int i = 0; i < len; i++)
        //    {
        //        arr[i] = int.Parse(Console.ReadLine());
                
        //    }
        //    return arr;
        //}
        public static bool checkSorted(int[] arr)
        {
            for(int i=0; i<arr.Length-1; i++)
            {
                if (arr[i] >arr[i + 1])
                {
                    return false;
                    
                }
                
            }
            return true;
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  "); // Changed WriteLine to Write to print on the same line.
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 ,6,8,10,9,4};
            int[] arr2 = { 1, 2, 3, 6, 8, 10, 9, 4 };
            //int[] arr= arrayip();
            //int[] arrbubbleSort = (int[])arr;
            //int[] arrInsertionSort = (int[])arr.Clone();



            Console.WriteLine("array without bubble sort");
            Print(arr1);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            BubbleSort(arr1);
            stopwatch.Stop();
            Console.WriteLine("array with bubble sort");
            Print(arr1);

            bool check = checkSorted(arr1);
            if (check) { Console.WriteLine("Array is Sorted"); }
            else { Console.WriteLine("unsorted"); }
            
            Console.WriteLine($"ArraySize {arr1.Length} Time TAken by bubblesort {stopwatch.Elapsed.TotalMilliseconds} milliseconds");

            Console.WriteLine("array without bubble sort");
            Print(arr2);
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch.Start();

            insertionSort(arr2);
            stopwatch.Stop();
            Console.WriteLine("array with insertion sort");
            Print(arr2);
            bool check2 = checkSorted(arr2);
            if (check2) { Console.WriteLine("Array is Sorted by insertionsort"); }
            else { Console.WriteLine("unsorted"); }
            Console.WriteLine(  "\n\n");
            

            Console.WriteLine($"ArraySize {arr2.Length} Time TAken  by insertion Sort {stopwatch.Elapsed.TotalMilliseconds} milliseconds");


            Console.ReadLine();
        }
    }
}