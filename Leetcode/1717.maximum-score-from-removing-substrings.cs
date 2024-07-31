/*
 * @lc app=leetcode id=1717 lang=csharp
 *
 * [1717] Maximum Score From Removing Substrings
 */

// @lc code=start
public class Solution {
    public int MaximumGain(string s, int x, int y) {
        Stack<char> stack1 = new(),
            stack2 = new();
        
        int result = 0,
            max = 0,
            min = 0;
        char first = 'a',
            second = 'b';
        if (x >= y)
        {
            max = x;
            min = y;
            first = 'a';
            second = 'b';
        }
        else
        {
            max = y;
            min = x;
            first = 'b';
            second = 'a';
        }

        foreach (char c in s)
        {
            if (c == second &&
                stack1.Count > 0 &&
                stack1.Peek() == first)
            {
                stack1.Pop();
                result += max;
            }
            else
            {
                stack1.Push(c);
            }
        }

        while (stack1.Count > 0)
        {
            char c = stack1.Pop();
            if (c == second &&
                stack2.Count > 0 &&
                stack2.Peek() == first)
            {
                stack2.Pop();
                result += min;
            }
            else
            {
                stack2.Push(c);
            }
        }

        return result;
    }
}
// @lc code=end

