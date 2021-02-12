// Converting infix to prefix
using System;
using System.Collections.Generic;

public class infixToPrefix
{
    //Function to check if character is operator
    static bool isOperator (char c)
    {
        return !char.IsDigit(c);
        //return (!(c >= '0' && c <= '9');
    }
    // Function to find priority of given operator
    static int getPriority(char C)
    {
        if (C == '-' || C == '+')
            return 1;
        else if (C == '*' || C == '/')
            return 2;
        else if (C == '^')
            return 3;
        return 0;
    }
    // Function that converts infix to prefix expression
    static String infixToPrefix(String infix)
    {
        // stack for operators
        Stack<char> operators = new Stack<char>();

        // stack for operands
        Stack<string> operands = new Stack<string>();

        for (int i = 0; i < infix.Length; i++)
        {
            // if current character is an opening bracket, push into operators stack
            if (infix[i] == '(')
            {
                operators.Push(infix[i]);
            }
            // if current character is a closing bracket, pop from both stacks and push result
            // in operands stack until matching opening bracket is not found
            else if (infix[i] == ')')
            {
                while (operators.Count!=0 && operators.Peek() != '(')
                {
                    // operand 1
                    String op1 = operands.Peek();
                    operands.Pop();

                    // operand 2
                    String op2 = operands.Peek();
                    operands.Pop();

                    //operator
                    char op = operators.Peek();
                    operators.Pop();

                    // Add operands and operator in form operator + operand1 + operand 2
                    string temp = op + op2 + op1;
                    operands.Push(temp);
                }

                // Pop opening bracket from stack
                operators.Pop();
            }

            // If current character is an operand, push it into operands stack
            else if (!isOperator(infix[i] + ""))
            {
                operands.Push(infix[i] + "");
            }
            // if current character is an operator, push it into operators stack after popping
            // high priority operators from operators stack and pushing result in operands stack
            else
            {
                while (operators.Count!=0 && getPriority(infix[i]) <= getPriority(operators.Peek()))
                {
                    String op1 = operands.Peek();
                    operands.Pop();

                    String op2 = operands.Peek();
                    operands.Pop();

                    char op = operators.Peek();
                    operators.Pop();

                    String temp = op + op2 + op1;
                    operands.Push(temp);
                }
                operators.Push(infix[i]);
            }
        }

        // pop operators from operators stack until empty and operation in add result of each pop operands stack
        while (operators.Count != 0)
        {
            String op1 = operands.Peek();
            operands.Pop();

            String op2 = operands.Peek();
            operands.Pop();

            char op = operators.Peek();
            operators.Pop();

            String temp = op + op2 + op1;
            operands.Push(temp);
        }

        // final prefix expression is present in operands stack
        return operands.Peek();
    }
    public static void Main(string[] args)
    {
        string s = ""
        Console.WriteLine(infixToPrefix(s);
    }
}
