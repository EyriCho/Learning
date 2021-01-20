/*
 * @lc app=leetcode id=227 lang=csharp
 *
 * [227] Basic Calculator II
 */

// @lc code=start
public class Solution {
    public int Calculate(string s) {
        if (string.IsNullOrEmpty(s))
            return 0;
        
        Stack<int> operands = new Stack<int>();

        int num = 0;
        char oper = '+';
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= '0')
                num = num * 10 + (s[i] - '0');
            if ((s[i] < '0' && s[i] != ' ') || i == s.Length - 1)
            {
                if (oper == '-')
                    num = -num;
                else if (oper == '*')
                    num = operands.Pop() * num;
                else if (oper == '/')
                    num = operands.Pop() / num;
                operands.Push(num);
                oper = s[i];
                num = 0;
            }
        }
        
        num = 0;
        while (operands.Count > 0)
        {
            num += operands.Pop();
        }
        
        return num;
    }
}
// @lc code=end

