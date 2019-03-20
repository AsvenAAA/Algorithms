using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchMethods
{
    class ReversePolishEntry
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

        public ReversePolishEntry(string Expression)
        {
            this.Expression = Expression;
        }

        public void RPEformer(string expression)
        {
            StringBuilder sRPE = new StringBuilder();
            Stack<string> operandsStack = new Stack<string>(Expression.Length);

            for (int substringNumb = 0; substringNumb < expression.Length; substringNumb++)
            {
                if ("0123456789".Contains(expression[substringNumb]))
                {
                    sRPE.Append(expression[substringNumb]);
                }
                else
                {
                    if (operandsStack.Count == 0)
                        operandsStack.Push(expression[substringNumb].ToString());
                    else
                    {
                        if (PriorityChecker(expression[substringNumb]) > PriorityChecker(char.Parse(operandsStack.Peek())))
                        {
                            while(operandsStack.Count != 0 && PriorityChecker(expression[substringNumb]) > PriorityChecker(char.Parse(operandsStack.Peek())))
                            {
                                switch(operandsStack.Peek().ToString)
                                    case "(":
                                        break;
                                        

                                operandsStack.Push(expression[substringNumb].ToString());                           

                            }
                        }
                        else if (PriorityChecker(expression[substringNumb]) <= PriorityChecker(char.Parse(operandsStack.Peek())))
                        {
                            while (operandsStack.Count != 0 && PriorityChecker(expression[substringNumb]) <= PriorityChecker(char.Parse(operandsStack.Peek())))
                            {
                                sRPE.Append(operandsStack.Pop());
                            }
                            operandsStack.Push(expression[substringNumb].ToString());
                        }
                        //switch (operandsStack.Peek().ToString())
                        //{
                        //    case "(":
                        //        operandsStack.Pop();
                        //        Console.WriteLine("The '(' Pop");
                        //        break;
                        //    case ")":
                        //        operandsStack.Pop();
                        //        Console.WriteLine("The ')' Pop");
                        //        break;
                        //    default:
                        //        Console.WriteLine("Default Pop: {0}", operandsStack.Peek());
                        //        sRPE.Append(operandsStack.Pop());
                        //        operandsStack.Push(expression[substringNumb].ToString());
                        //        break;
                    }
                }
                if(substringNumb == expression.Length - 1)
                {
                    while(operandsStack.Count != 0 )
                    {
                        sRPE.Append(operandsStack.Pop());
                    }
                }
            }
            Console.WriteLine(sRPE);
        }

        public byte PriorityChecker(char symbol)
        {
            if ("+-*/()".Contains((symbol)))
            {
                switch (symbol)
                {
                    case '+': return 1;
                    case '-': return 1;
                    case '*': return 2;
                    case '/': return 2;
                    case '(': return 0;
                    case ')': return 0;
                    default: throw new Exception("There is no such operation in the program!");
                }
            }
            else return 9;
        }

        //public double Calculate(string reversePolishEntry)
        //{
        //    for(int sSubstring = 0; sSubstring < reversePolishEntry.Length; sSubstring++)
        //    {

        //    }
        //}

    }
}
