using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace SearchMethods
{
    class Program
    {
        public static int ArrayLen { get; set; }

        static void Main(string[] args)
        {
            Program sortingAlgorithms = new Program();
            ArrayLen = 30000;

            sortingAlgorithms.BubbleSorting(ArrayLen);
            sortingAlgorithms.ShakerSorting(ArrayLen);
            sortingAlgorithms.EvenOddSorting(ArrayLen);

            sortingAlgorithms.NativeFastSorting(ArrayLen);

            Console.ReadKey();
        }

        public void NativeFastSorting(int lArray)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            int[] randomArray = new int[lArray];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(-1000, 1000);
            }

            Array.Sort(randomArray);

            timer.Stop();

            Console.WriteLine("Native fast sorting: {0}", timer.ElapsedMilliseconds / 100.0);

        }

        #region BubbleSorting
        public void BubbleSorting(int lArray)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            int[] randomArray = new int[lArray];
            Random rnd = new Random();
            for(int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(-1000, 1000);
            }

            //Console.WriteLine("Before");
            //for (int i = 0; i < randomArray.Length; i++)
            //    Console.WriteLine(randomArray[i]);

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

            //Console.WriteLine("\nAfter");
            //for (int i = 0; i < randomArray.Length; i++)
            //    Console.WriteLine(randomArray[i]);

            timer.Stop();
            Console.WriteLine("Bubble sorting time: {0}", timer.ElapsedMilliseconds / 100.0);
        }
        #endregion

        #region ShakerSorting
        public void ShakerSorting(int lArray)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            int[] randomArray = new int[lArray];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(-1000, 1000);
            }

            //Console.WriteLine("Before");
            //for (int i = 0; i < randomArray.Length; i++)
            //    Console.WriteLine(randomArray[i]);

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

            //Console.WriteLine("\nAfter");
            //for (int i = 0; i < randomArray.Length; i++)
            //    Console.WriteLine(randomArray[i]);

            timer.Stop();
            Console.WriteLine("Shaker sorting time: {0}", timer.ElapsedMilliseconds / 100.0);
        }
        #endregion

        #region EvenOddSorting
        public void EvenOddSorting(int lArray)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            int[] randomArray = new int[lArray];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(-1000, 1000);
            }

            //Console.WriteLine("Before");
            //for (int i = 0; i < randomArray.Length; i++)
            //    Console.WriteLine(randomArray[i]);
            int countF = 0;
            int countS = 0;
            while (true)
            {
                for (int i = 1, j = i + 1; i < randomArray.Length & j < randomArray.Length; i += 2, j += 2)
                {
                        if (randomArray[i] > randomArray[j])
                        {
                            int permutation = randomArray[i];
                            randomArray[i] = randomArray[j];
                            randomArray[j] = permutation;
                            countF += 1;
                        }
                }
                for (int i = 0, j = i + 1; i < randomArray.Length & j < randomArray.Length; i += 2, j += 2)
                {
                        if (randomArray[i] > randomArray[j])
                        {
                            int permutation = randomArray[i];
                            randomArray[i] = randomArray[j];
                            randomArray[j] = permutation;
                            countF += 1;
                        }
                }
                if (countF > countS)
                    countS = countF;
                else break;
            }

            //Console.WriteLine("\nAfter");
            //for (int i = 0; i < randomArray.Length; i++)
            //    Console.WriteLine(randomArray[i]);

            timer.Stop();
            Console.WriteLine("Even-odd sorting time: {0}", timer.ElapsedMilliseconds / 100.0);
        }
        #endregion
    }
}
