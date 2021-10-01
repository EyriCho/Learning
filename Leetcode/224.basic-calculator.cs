/*
 * @lc app=leetcode id=224 lang=csharp
 *
 * [224] Basic Calculator
 */

// @lc code=start
public class Solution {
    public int Calculate(string s) {
        var numStack = new Stack<int>();
        numStack.Push(0);
        int num = 0, sign = 1, result = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                continue;
            
            if (s[i] == '(')
            {
                numStack.Push(result);
                numStack.Push(sign);
                result = 0;
                sign = 1;
            }
            else if (s[i] == ')')
            {
                result += sign * num;
                num = 0;
                result *= numStack.Pop();
                result += numStack.Pop();
            }
            else if (s[i] == '+' || s[i] == '-')
            {
                result += sign * num;
                num = 0;
                sign = s[i] == '+' ? 1 : -1;
            }
            else
            {
                num = num * 10 + (s[i] - '0');
            }
        }
        
        result += sign * num;
        
        return result;
    }
}
// @lc code=end

