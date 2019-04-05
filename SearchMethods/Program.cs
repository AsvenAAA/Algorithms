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

            //SortingAlgorithms sortingAlgorithms = new SortingAlgorithms(3000000);

            //sortingAlgorithms.BubbleSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            //sortingAlgorithms.ShakerSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            //sortingAlgorithms.EvenOddSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            //sortingAlgorithms.CombSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));

            //sortingAlgorithms.NativeFastSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            //((5+5)*2+6*8-8/7+5)*
            //(9(5+6)*8(4-5+6)/7)
            ReversePolishEntry rpe = new ReversePolishEntry("(8+2*5)/(1+3*2-4)+5*8/7+9-8*8/645+(545*787987+55)/((5+9-8/7)*5)");
            Console.WriteLine(rpe.RPEformer(rpe.Expression));
            Console.WriteLine(rpe.Calculate(rpe.RPEformer(rpe.Expression)));
            Console.ReadKey();

        }
    }
}
