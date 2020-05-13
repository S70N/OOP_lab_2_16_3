using System;

namespace OOP_lab_2_16_3
{
    class Program
    {
        public static int MinAbs(int[] array)
        {
            int min = Math.Abs(array[0]);

            for (int i = 0; i < array.Length; ++i)
            {
                if (min >= Math.Abs(array[i]))
                {
                    min = Math.Abs(array[i]);
                }
            }

            return min;
        }

        public static int MultiplicationBetweenFirstAndLastZeroes(int[] array)
        {
            int firstZeroIndex = 0;
            int lastZeroIndex = 0;

            int d = 1;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == 0)
                {
                    firstZeroIndex = i;
                    break;
                }
            }

            for (int i = array.Length - 1; i >= firstZeroIndex; --i)
            {
                if (array[i] == 0)
                {
                    lastZeroIndex = i;
                    break;
                }
            }

            if (firstZeroIndex != lastZeroIndex)
            {
                for (int i = firstZeroIndex + 1; i < lastZeroIndex; ++i)
                {
                    d *= array[i];
                }
            }
            else
            {
                return 0;
            }

            return d;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            var random = new Random();

            for (int i = 0; i < a.Length; ++i)
            {
                a[i] = random.Next(-100, 100);
            }

            for (int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Miнiмальний за модулем елемент масиву: {0}", MinAbs(a));
            Console.WriteLine("Добуток елементiв масиву, розташованих мiж першим й останнiм нульовими елементами: {0}", MultiplicationBetweenFirstAndLastZeroes(a));
        }
    }
}
