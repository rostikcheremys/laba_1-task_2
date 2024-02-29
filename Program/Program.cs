using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    internal abstract class Program
    {
        private delegate bool IsMultiple(int number, int k);
        
        public static void Main()
        {
            int[] numbers = { 5, 15, 25, 70, 95 };
            
            Console.Write("Введіть значення k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            
            IsMultiple isMultiple = (number, index) => number % k == 0;
            
            Console.WriteLine($"1) Результат: {string.Join(" ", FirstTask(numbers, k, isMultiple))}");
            Console.WriteLine($"2) Результат: {string.Join(" ", SecondTask(numbers, k, isMultiple))}");
        }

        private static int[] FirstTask(int[] numbers, int k, IsMultiple isMultiple)
        {
            int[] newArray = numbers.Where(number => isMultiple(number, k)).ToArray();

            return newArray;
        }
        
        private static int[] SecondTask(int[] numbers, int k, IsMultiple isMultiple)
        {
            int count = 0;
            
            foreach (int number in numbers)
            {
                if (isMultiple(number, k))
                {
                    count++;
                }
            }

            int[] newArray = new int[count];
            int num = 0;

            foreach (int number in numbers)
            {
                if (isMultiple(number, k))
                {
                    newArray[num++] = number;
                }
            }

            return newArray;
        }
    }
}