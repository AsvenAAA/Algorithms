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

        public string RPEformer(string expression)
        {
            StringBuilder sRPE = new StringBuilder();
            Stack<string> operandsStack = new Stack<string>(Expression.Length);
            byte zeroLength = 0;

            for (int substringNumb = 0; substringNumb < expression.Length; substringNumb++)
            {
                if ("0123456789".Contains(expression[substringNumb]))
                {
                    sRPE.Append(expression[substringNumb]);
                }
                else
                {
                    if ("+-*/".Contains(expression[substringNumb])) sRPE.Append(" ");
                    if (operandsStack.Count == zeroLength) operandsStack.Push(expression[substringNumb].ToString());
                    else
                    {
                        if (PriorityChecker(expression[substringNumb]) > PriorityChecker(char.Parse(operandsStack.Peek())))
                        {
                            while(operandsStack.Count != zeroLength && PriorityChecker(expression[substringNumb]) > PriorityChecker(char.Parse(operandsStack.Peek())))
                            {
                                if(expression[substringNumb].ToString() == ")")
                                {
                                    while (operandsStack.Count != zeroLength && operandsStack.Peek().ToString() != "(")
                                    {
                                        sRPE.Append(operandsStack.Pop());
                                    }
                                    if (operandsStack.Count != zeroLength && operandsStack.Peek() == "(")
                                    {
                                        operandsStack.Pop();
                                        break;
                                    }
                                }
                                else operandsStack.Push(expression[substringNumb].ToString());
                            }
                        }
                        else if (PriorityChecker(expression[substringNumb]) <= PriorityChecker(char.Parse(operandsStack.Peek())))
                        {
                            while (operandsStack.Count != zeroLength && PriorityChecker(expression[substringNumb]) <= PriorityChecker(char.Parse(operandsStack.Peek())) & expression[substringNumb].ToString() != "(")
                            {
                                sRPE.Append(operandsStack.Pop());
                            }
                            operandsStack.Push(expression[substringNumb].ToString());
                        }
                    }
                }
                if(substringNumb == expression.Length - 1)
                {
                    while(operandsStack.Count != zeroLength)
                    {
                        if (operandsStack.Peek() == ")") operandsStack.Pop();
                        else sRPE.Append(operandsStack.Pop());
                    }
                }
            }
            return sRPE.ToString();
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

        public double Add(double x, double y) {return y + x;}
        public double Sub(double x, double y) { return y - x;}
        public double Mult(double x, double y) {return y * x;}
        public double Div(double x, double y) {return y / x;}

        public double Calculate(string reversePolishEntry)
        {
            StringBuilder expressionOperator = new StringBuilder();
            Stack<string> operators = new Stack<string>();
            byte zeroLength = 0;

            for (int symbolNumb = 0; symbolNumb < reversePolishEntry.Length; symbolNumb++)
            {
                if ("0123456789".Contains(reversePolishEntry[symbolNumb]))
                {
                    expressionOperator.Append(reversePolishEntry[symbolNumb]); if (symbolNumb < reversePolishEntry.Length & "+-*/".Contains(reversePolishEntry[symbolNumb + 1]))
                    {
                        operators.Push(expressionOperator.ToString());
                        expressionOperator.Clear();
                    }
                }
                else if (expressionOperator.Length > zeroLength & reversePolishEntry[symbolNumb] == ' ')
                {
                    operators.Push(expressionOperator.ToString());
                    expressionOperator.Clear();
                }
                else if ("+-*/".Contains(reversePolishEntry[symbolNumb]))
                {
                    switch (reversePolishEntry[symbolNumb])
                    {
                        case '+':
                            operators.Push(Add(double.Parse(operators.Pop()), double.Parse(operators.Pop())).ToString());
                            break;
                        case '-':
                            operators.Push(Sub(double.Parse(operators.Pop()), double.Parse(operators.Pop())).ToString());
                            break;
                        case '*':
                            operators.Push(Mult(double.Parse(operators.Pop()), double.Parse(operators.Pop())).ToString());
                            break;
                        case '/':
                            operators.Push(Div(double.Parse(operators.Pop()), double.Parse(operators.Pop())).ToString());
                            break;
                    }
                }
            }
            return double.Parse(operators.Pop());
        }
    }
}
