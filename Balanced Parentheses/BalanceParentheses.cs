using System;
using System.Linq;

namespace FellowShip_DataStructure.Balanced_Parentheses
{
    public class BalanceParentheses
    {
        ParanthesesUtility utility = new ParanthesesUtility();
        public bool Parentheses()
        {
            string expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression.ElementAt(i) == '(')
                {
                    object dataObject = (object)Convert.ChangeType(expression.ElementAt(i), typeof(object));
                    utility.Push(dataObject);
                }
                else if (expression.ElementAt(i) == ')')
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        utility.Pop();
                        if (expression.ElementAt(j) == ')')
                        {
                            return false;
                        }
                        else if (expression.ElementAt(j) == '(')
                        {
                            utility.Pop();
                            break;
                        }
                    }
                }
                else
                {
                    utility.Push(expression.ElementAt(i));
                }
            }

            if (utility.IsEmpty())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
