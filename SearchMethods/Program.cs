﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.EvenOddSorting();
            Console.ReadKey();
        }

        #region BubbleSorting
        public void BubbleSorting()
        {
            int[] randomArray = new int[10];
            Random rnd = new Random();
            for(int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(-100, 100);
            }

            Console.WriteLine("Before");
            for (int i = 0; i < randomArray.Length; i++)
                Console.WriteLine(randomArray[i]);

            int lengthArray = randomArray.Length;
            while (lengthArray != 0)
            {
                for (int i = 0, j = i + 1; i < lengthArray & j < lengthArray; i++, j++)
                {
                    if (randomArray[i] > randomArray[j])
                    {
                        int permutation = randomArray[i];
                        randomArray[i] = randomArray[j];
                        randomArray[j] = permutation;
                    }
                }
                lengthArray -= 1;
            }

            Console.WriteLine("\nAfter");
            for (int i = 0; i < randomArray.Length; i++)
                Console.WriteLine(randomArray[i]);
        }
        #endregion

        #region ShakerSorting
        public void ShakerSorting()
        {
            int[] randomArray = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(-100, 100);
            }

            Console.WriteLine("Before");
            for (int i = 0; i < randomArray.Length; i++)
                Console.WriteLine(randomArray[i]);

            int lengthArray = randomArray.Length;
            int buff = 0;
            while (lengthArray != 0)
            {
                for (int i = 0, j = i + 1; i < lengthArray & j < lengthArray; i++, j++)
                {
                    if (randomArray[i] > randomArray[j])
                    {
                        int permutation = randomArray[i];
                        randomArray[i] = randomArray[j];
                        randomArray[j] = permutation;
                    }
                }
                for (int i = lengthArray - 1, j = i - 1; i >= buff & j >= buff; i--, j--)
                {
                    if (randomArray[i] < randomArray[j])
                    {
                        int permutation = randomArray[i];
                        randomArray[i] = randomArray[j];
                        randomArray[j] = permutation;
                    }
                    buff += 1;
                }

                lengthArray -= 1;
            }

            Console.WriteLine("\nAfter");
            for (int i = 0; i < randomArray.Length; i++)
                Console.WriteLine(randomArray[i]);
        }
        #endregion

        #region EvenOddSorting
        public void EvenOddSorting()
        {
            int[] randomArray = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(-100, 100);
            }

            Console.WriteLine("Before");
            for (int i = 0; i < randomArray.Length; i++)
                Console.WriteLine(randomArray[i]);
            int countF = 0;
            int countS = 0;
            while (true)
            {
                for (int i = 0, j = i + 1; i < randomArray.Length & j < randomArray.Length; i++, j++)
                {
                    if (i % 2 != 0)
                    {
                        if (randomArray[i] > randomArray[j])
                        {
                            int permutation = randomArray[i];
                            randomArray[i] = randomArray[j];
                            randomArray[j] = permutation;
                            countF += 1;
                        }
                    }
                }
                for (int i = 0, j = i + 1; i < randomArray.Length & j < randomArray.Length; i++, j++)
                {
                    if (i % 2 == 0)
                    {
                        if (randomArray[i] > randomArray[j])
                        {
                            int permutation = randomArray[i];
                            randomArray[i] = randomArray[j];
                            randomArray[j] = permutation;
                            countF += 1;
                        }
                    }
                }
                if (countF > countS)
                    countS = countF;
                else break;
            }

            Console.WriteLine("\nAfter");
            for (int i = 0; i < randomArray.Length; i++)
                Console.WriteLine(randomArray[i]);
        }
        #endregion
    }
}
