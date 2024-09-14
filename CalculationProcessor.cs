using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCalc;

namespace mathsharp
{
    internal class CalculationProcessor
    {
        public static Object CalculateExpression(String prompt)
        {
            Expression expression = new Expression(prompt);
            return expression.Evaluate();
        }
    }
}
