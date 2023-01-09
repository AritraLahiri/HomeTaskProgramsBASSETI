using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeTaskPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*thirdProgram();*/
            /*firstProgram();*/
            /*secondProgram();*/
            /*  fourthProgram();*/
        }

        private static void fourthProgram()
        {

            int[] a = { 12, 3, 6, 15, 18, 14, 24, 96, 25, 23 };
            int n = a.Length;
            int[] res = findEven(a, n);
            foreach (int i in res)
            {
                Console.Write(i + " ");
            }


        }

        private static int[] findEven(int[] a, int n)
        {

            if (a == null || n <= 0) return null;


            ArrayList res = new ArrayList();
            foreach (int i in a)
            {
                if (i % 2 == 0) res.Add(i);
            }

            return (int[])res.ToArray(typeof(int));


        }

        private static void thirdProgram()
        {
            int[] arr1 = { 11, 22, 44, 99, 77, 33 };
            int[] arr2 = { 2, 3, 4, 5, 6 };
            int[] arr3 = { 22, 32, 42, 52, 62 };
            int[] arr4 = { 21, 33, 45, 59, 61 };
            int[] arr5 = { 21 };

            int n = arr3.Length;
            sortEvenOdd(arr3, n);
            foreach (int i in arr3)
            {
                Console.Write(i + " ");
            }
        }

        private static void sortEvenOdd(int[] arr, int n)
        {

            int left = 0, right = n - 1;
            while (left < right)
            {
                while (left < n && arr[left] % 2 != 0) left++;
                while (right >= 0 && arr[right] % 2 == 0) right--;
                if (left < right)
                {
                    (arr[right], arr[left]) = (arr[left], arr[right]);
                }
            }

            /* Console.WriteLine(left);
             Console.WriteLine(right);*/
            Array.Sort(arr, 0, left);
            Array.Sort(arr, left, n - left);







        }

        private static void secondProgram()
        {
            int[] arr2 = { 50, 45, 50, 45, 10, 5 };
            int[] arr1 = { 50, 50, 50 };
            int[] arr3 = { -50, -40, -50, -45, -1 };
            int n = arr2.Length;
            int res = findSecondMax(arr2, n);
            if (res == int.MinValue) Console.WriteLine("Not Present");
            else Console.WriteLine(res);
        }

        private static int findSecondMax(int[] arr, int n)
        {


            int firstMax = arr[0];
            int secondMax = int.MinValue;
            foreach (int i in arr)
            {
                firstMax = Math.Max(i, firstMax);
            }

            /**//*Console.WriteLine("first largest is " + firstMax);*/
            foreach (int item in arr)
            {
                if (item > secondMax && item != firstMax)
                {
                    secondMax = item;
                }
            }


            return secondMax;









        }

        private static void firstProgram()
        {
            Console.WriteLine("Enter array size");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) return;
            int[] arr = new int[n];
            int i = 0;
            while (n-- > 0)
            {
                Console.WriteLine($"Enter {i}th element ");
                arr[i++] = int.Parse(Console.ReadLine());

            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");

            }

            Console.WriteLine("Enter the index to count Occurence");
            int index = int.Parse(Console.ReadLine());

            int res = CountIndexItems(arr, index);
            if (res == -1) Console.WriteLine("Invalid Input ! ");

            Console.WriteLine($" {index}th element has occured  {res} times");
        }
        private static int CountIndexItems(int[] a, int index)
        {

            int n = a.Length;
            if (index < 0 || index >= n) return -1;
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int item in a)
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map.Add(item, 1);
                }
            }

            /*      foreach (KeyValuePair<int, int> entry in map)
                  {
                      Console.WriteLine(entry.Key + " times " + entry.Value);
                  }*/

            return map.ContainsKey(a[index]) ? map[a[index]] : -1;



        }
    }



}
