using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_7
{
    class Program
    {
        private static int IsPrime(int number)
        {
            if (number == 2 || number == 3 || number == 5 || number == 7 || number == 9)
            {
                Console.WriteLine("1");
            }
            else if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0 || number % 9 == 0)
            {
                Console.WriteLine("0");
            }
            else if (number % 2 != 0 || number % 3 != 0 || number % 5 != 0 || number % 7 != 0 || number % 9 != 0)
            {
                Console.WriteLine("1");
            }
            return number;
        }
        private static void CheckArrayForPrimeNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==2||arr[i]==3|| arr[i]==5|| arr[i]==7|| arr[i] == 9)
                {
                    Console.WriteLine(arr[i] + " is prime!");
                }
                else if (arr[i]%2==0|| arr[i]%3==0|| arr[i]%5==0|| arr[i]%7==0|| arr[i] % 9 == 0)
                {
                    Console.WriteLine(arr[i] + " not prime!");
                }
                else if (arr[i]%2!=0|| arr[i]%3!=0|| arr[i]%5!=0|| arr[i]%7!=0|| arr[i] % 9 != 0)
                {
                    Console.WriteLine(arr[i] + " is prime!");
                }
            }
        }
        private static int WhichArrayIsBigger(int[] arr1, int[] arr2)
        {
            int sum_arr1 = 0;
            int sum_arr2 = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum_arr1 = sum_arr1 + arr1[i];
            }
            for (int j = 0; j < arr2.Length; j++)
            {
                sum_arr2 = sum_arr2 + arr2[j];
            }
            Console.WriteLine("arr1 sum is: " + sum_arr1);
            Console.WriteLine("arr2 sum is: " + sum_arr2);
            if (sum_arr1 > sum_arr2)
            {
                Console.WriteLine("1");
            }
            else if (sum_arr1 == sum_arr2)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-1");
            }
            return sum_arr2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            IsPrime(Convert.ToInt32(Console.ReadLine()));
            CheckArrayForPrimeNumbers(new int[] { 2, 4, 9, 13, 17 });
            WhichArrayIsBigger(new int[] { 2, 4, 6, 8, 10 }, new int[] { 1, 3, 5, 7, 9 });
        }
    }
}
