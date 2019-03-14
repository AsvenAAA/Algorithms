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

            string sExpression = "9+7*1+4/2";
            int nReversePolishEntryCount = 0;
            int nStackCounter = 0;

            string sPatternOperand = @"[-+*/()]";
            string sPatternOperator = @"[\d]";
            string[] aOperands = Regex.Split(sExpression, sPatternOperand);
            string[] aOperators = Regex.Split(sExpression, sPatternOperator);
            string[] aStack = new string[aOperators.Length - 2];
            string[] aReversePolishEntry = new string[aOperands.Length + (aOperators.Length - 2)];

            for (int i = 0; i < aReversePolishEntry.Length; i++)
            {
                if (sExpression[i].ToString() == "0" || sExpression[i].ToString() == "1" || sExpression[i].ToString() == "2" || sExpression[i].ToString() == "3" || sExpression[i].ToString() == "4" ||
                   sExpression[i].ToString() == "5" || sExpression[i].ToString() == "6" || sExpression[i].ToString() == "7" || sExpression[i].ToString() == "8" || sExpression[i].ToString() == "9")
                {
                    aReversePolishEntry[nReversePolishEntryCount] = sExpression[i].ToString();
                    nReversePolishEntryCount++;
                }
                else
                {
                    if(aStack[0] == null)
                    {
                        aStack[0] = sExpression[i].ToString();
                    }
                    else
                    {
                        //nReversePolishEntryCount++;
                        if (OperationPriorityChecker(aStack[nStackCounter]) >= OperationPriorityChecker(sExpression[i].ToString()))
                        {
                            aReversePolishEntry[nReversePolishEntryCount] = aStack[nStackCounter];
                            aStack[nStackCounter] = sExpression[i].ToString();
                        }
                        else
                        {
                            nStackCounter++;
                            aStack[nStackCounter] = sExpression[i].ToString();
                        }
                    }
                }
            }
            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        public static int OperationPriorityChecker(string sOperator)
        {
            int nPriority;
            switch (sOperator)
            {
                case "+":
                    return nPriority = 1;
                case "-":
                    return nPriority = 1;
                case "*":
                    return nPriority = 2;
                case "/":
                    return nPriority = 2;
                case "(":
                    return nPriority = 3;
                case ")":
                    return nPriority = 3;
                default:
                    Console.WriteLine("Don't understand operator");
                    return 0;
            }
        }
    }
}
