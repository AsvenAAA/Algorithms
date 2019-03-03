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
        static void Main(string[] args)
        {

            SortingAlgorithms sortingAlgorithms = new SortingAlgorithms(30000);

            sortingAlgorithms.BubbleSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            sortingAlgorithms.ShakerSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            sortingAlgorithms.EvenOddSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));
            sortingAlgorithms.CombSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));

            sortingAlgorithms.NativeFastSorting(sortingAlgorithms.ArrayBuilder(sortingAlgorithms.ArrayLen));

            Console.ReadKey();
        }


    }
}
