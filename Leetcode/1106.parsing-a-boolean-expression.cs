/*
 * @lc app=leetcode id=1106 lang=csharp
 *
 * [1106] Parsing A Boolean Expression
 */

// @lc code=start
public class Solution {
    public bool ParseBoolExpr(string expression) {
        if (expression[0] == 't')
        {
            return true;
        }
        else if (expression[0] == 'f')
        {
            return false;
        }
        else if (expression[0] == '!')
        {
            return !ParseBoolExpr(expression[2..^1]);
        }
        else if (expression[0] == '&')
        {
            int bracket = 0,
                left = 2,
                right = 2,
                last = expression.Length - 1;

            while (right < last)
            {
                if (expression[right] == '(')
                {
                    bracket++;
                }
                else if (expression[right] == ')')
                {
                    bracket--;
                }
                else if (expression[right] == ',' && bracket == 0)
                {
                    if (!ParseBoolExpr(expression[left..right]))
                    {
                        return false;
                    }
                    left = right + 1;
                }

                right++;
            }

            return ParseBoolExpr(expression[left..right]);
        }
        else
        {
            int bracket = 0,
                left = 2,
                right = 2,
                last = expression.Length - 1;

            while (right < last)
            {
                if (expression[right] == '(')
                {
                    bracket++;
                }
                else if (expression[right] == ')')
                {
                    bracket--;
                }
                else if (expression[right] == ',' && bracket == 0)
                {
                    if (ParseBoolExpr(expression[left..right]))
                    {
                        return true;
                    }
                    left = right + 1;
                }

                right++;
            }

            return ParseBoolExpr(expression[left..right]);
        }
    }
}
// @lc code=end

