using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace SearchMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            SortingAlgorithms sortingAlgorithms = new SortingAlgorithms(30000);

            //sortingAlgorithms.BubbleSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            //sortingAlgorithms.ShakerSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            //sortingAlgorithms.EvenOddSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            //sortingAlgorithms.CombSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));

            //sortingAlgorithms.NativeFastSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));

            ReversePolishEntry rpe = new ReversePolishEntry("7+3*4/8-4+8/4*9-5+9*7/9+2");
            rpe.RPEformer(rpe.Expression);

            Console.ReadKey();

        }
    }
}
