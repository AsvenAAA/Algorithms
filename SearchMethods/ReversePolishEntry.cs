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
                                string check = expression[substringNumb].ToString();
                                switch(expression[substringNumb].ToString())
                                {
                                    case ")":
                                        while(operandsStack.Count != 0 && operandsStack.Peek().ToString() != "(")
                                        {
                                             sRPE.Append(operandsStack.Pop());
                                        }
                                        //if (operandsStack.Peek() == "(")
                                            operandsStack.Pop();
                                        break;
                                    default:
                                        operandsStack.Push(expression[substringNumb].ToString());
                                        break;
                                }
                            }
                        }
                        else if (PriorityChecker(expression[substringNumb]) <= PriorityChecker(char.Parse(operandsStack.Peek())))
                        {
                            while (operandsStack.Count != 0 && PriorityChecker(expression[substringNumb]) <= PriorityChecker(char.Parse(operandsStack.Peek())) & expression[substringNumb].ToString() != "(")
                            {
                                sRPE.Append(operandsStack.Pop());
                            }
                            operandsStack.Push(expression[substringNumb].ToString());
                        }
                    }
                }
                if(substringNumb == expression.Length - 1)
                {
                    while(operandsStack.Count != 0 )
                    {
                        if (operandsStack.Peek() == ")") operandsStack.Pop();
                        else sRPE.Append(operandsStack.Pop());
                    }
                }
            }
            Console.WriteLine(sRPE);
        }

        public byte PriorityChecker(char symbol)
        {
             switch (symbol)
             {
                 case '+': return 1;
                 case '-': return 1;
                 case '*': return 2;
                 case '/': return 2;
                 case '(': return 0;
                 case ')': return 3;
                 default: throw new Exception("There is no such operation in the program!");
             }
        }
    }
}
