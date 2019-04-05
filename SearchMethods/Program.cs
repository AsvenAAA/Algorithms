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

            SortingAlgorithms sortingAlgorithms = new SortingAlgorithms(3000000);

            //sortingAlgorithms.BubbleSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            //sortingAlgorithms.ShakerSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            //sortingAlgorithms.EvenOddSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            //sortingAlgorithms.CombSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));

            //sortingAlgorithms.NativeFastSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));

            ReversePolishEntry rpe = new ReversePolishEntry("(5*((8+6)+6*8))/((5+6)*(8/(8+5+6)*8-7)+6*8/9+(7+3)*5)");
            rpe.RPEformer(rpe.Expression);

            Console.ReadKey();

        }
    }
}
