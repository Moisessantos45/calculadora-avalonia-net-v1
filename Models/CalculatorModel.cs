using System;
using System.Collections.Generic;
using System.Globalization;

namespace Calculadora;

public class MultiBaseExpressionEvaluator
{
    public double EvaluateExpression(string expressionInput)
    {

        expressionInput = expressionInput.Replace(" ", "");
        var values = new Stack<double>();
        var operators = new Stack<char>();

        for (int i = 0; i < expressionInput.Length; i++)
        {

            if (char.IsLetterOrDigit(expressionInput[i]) || expressionInput[i] == '.')
            {
                string buffer = "";
                while (i < expressionInput.Length && (char.IsLetterOrDigit(expressionInput[i]) || expressionInput[i] == '.'))
                {
                    buffer += expressionInput[i++];
                }
                values.Push(ConvertToDecimal(buffer));
                i--;
            }

            else if (expressionInput[i] == '(') operators.Push('(');

            else if (expressionInput[i] == ')')
            {
                while (operators.Peek() != '(')
                    values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
                operators.Pop();
            }

            else if (IsOperator(expressionInput[i]))
            {

                if (expressionInput[i] == '-' && (i == 0 || expressionInput[i - 1] == '(' || IsOperator(expressionInput[i - 1])))
                {
                    values.Push(0);
                }

                while (operators.Count > 0 && GetOperatorPrecedence(operators.Peek()) >= GetOperatorPrecedence(expressionInput[i]))
                    values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
                operators.Push(expressionInput[i]);
            }
        }

        while (operators.Count > 0)
            values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));

        return values.Pop();
    }

    private int GetOperatorPrecedence(char op)
    {
        if (op == '+' || op == '-') return 1;
        if (op == '*' || op == '/') return 2;
        return 0;
    }

    private double ApplyOperation(char op, double b, double a)
    {
        return op switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b,
            _ => 0
        };
    }

    private bool IsOperator(char c) => "+-*/".Contains(c);

    private double ConvertToDecimal(string v)
    {
        v = v.ToLower();
        if (v.StartsWith("0x")) return Convert.ToInt32(v.Substring(2), 16);
        if (v.StartsWith("0b")) return Convert.ToInt32(v.Substring(2), 2);
        if (v.StartsWith("0o")) return Convert.ToInt32(v.Substring(2), 8);
        return double.Parse(v, CultureInfo.InvariantCulture);
    }


}