using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SearchMethods
{
    abstract class Algorithms
    {
        public int ArrayLen { get; set; }

        public virtual int[] ArrayBuilder(int lArray)
        {
            int[] randomArray = new int[lArray];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(-1000, 1000);
            }
            return randomArray;
        }

        public void NativeFastSorting(int[] array)
        {
            Stopwatch timer = new Stopwatch();

            timer.Start();
            Array.Sort(array);
            timer.Stop();

            Console.WriteLine("Native fast sorting: {0} time", timer.ElapsedMilliseconds / 100.0);
        }

        #region BubbleSorting
        public void BubbleSorting(int[] array)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            //Console.WriteLine("Before");
            //for (int i = 0; i < randomArray.Length; i++)
            //    Console.WriteLine(randomArray[i]);

            int lengthArray = array.Length;
            while (lengthArray != 0)
            {
                for (int i = 0, j = i + 1; i < lengthArray & j < lengthArray; i++, j++)
                {
                    if (array[i] > array[j])
                    {
                        int permutation = array[i];
                        array[i] = array[j];
                        array[j] = permutation;
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
        public void ShakerSorting(int[] array)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            //Console.WriteLine("Before");
            //for (int i = 0; i < randomArray.Length; i++)
            //    Console.WriteLine(randomArray[i]);

            int lengthArray = array.Length;
            int buff = 0;
            while (lengthArray != 0)
            {
                for (int i = 0, j = i + 1; i < lengthArray & j < lengthArray; i++, j++)
                {
                    if (array[i] > array[j])
                    {
                        int permutation = array[i];
                        array[i] = array[j];
                        array[j] = permutation;
                    }
                }
                for (int i = lengthArray - 1, j = i - 1; i >= buff & j >= buff; i--, j--)
                {
                    if (array[i] < array[j])
                    {
                        int permutation = array[i];
                        array[i] = array[j];
                        array[j] = permutation;
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
        public void EvenOddSorting(int[] array)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            //Console.WriteLine("Before");
            //for (int i = 0; i < randomArray.Length; i++)
            //    Console.WriteLine(randomArray[i]);
            int countF = 0;
            int countS = 0;
            while (true)
            {
                for (int i = 1, j = i + 1; i < array.Length & j < array.Length; i += 2, j += 2)
                {
                    if (array[i] > array[j])
                    {
                        int permutation = array[i];
                        array[i] = array[j];
                        array[j] = permutation;
                        countF += 1;
                    }
                }
                for (int i = 0, j = i + 1; i < array.Length & j < array.Length; i += 2, j += 2)
                {
                    if (array[i] > array[j])
                    {
                        int permutation = array[i];
                        array[i] = array[j];
                        array[j] = permutation;
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

        #region CombSorting
        public void CombSorting(int[] array)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            //Console.WriteLine("Before");
            //for (int i = 0; i < randomArray.Length; i++)
            //    Console.WriteLine(randomArray[i]);

            double factor = 1.27;
            int step = array.Length;
            while (step >= 1)
            {
                step = (int)(step / factor);
                for (int i = 0, j = i + step; i < array.Length && j < array.Length; i++, j++)
                {
                    if (array[i] > array[i + step])
                    {
                        int permutation = array[i];
                        array[i] = array[j];
                        array[j] = permutation;
                    }
                }
            }

            //Console.WriteLine("\nAfter");
            //for (int i = 0; i < randomArray.Length; i++)
            //    Console.WriteLine(randomArray[i]);

            timer.Stop();
            Console.WriteLine("Comb sorting time: {0}", timer.ElapsedMilliseconds / 100.0);
        }
        #endregion
    }

    class ReversePolishEntryAlgorithms
    {
        private string sExpression;
        public string Expression
        {
            get { return sExpression; }
            set
            {
                sExpression = value;
            }
        }
    }
}
