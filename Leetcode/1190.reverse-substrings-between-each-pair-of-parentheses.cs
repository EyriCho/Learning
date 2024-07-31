/*
 * @lc app=leetcode id=1190 lang=csharp
 *
 * [1190] Reverse Substrings Between Each Pair of Parentheses
 */

// @lc code=start
public class Solution {
    public string ReverseParentheses(string s) {
        int[] pair = new int[s.Length];

        Stack<int> stack = new ();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else if (s[i] == ')')
            {
                pair[i] = stack.Peek();
                pair[stack.Pop()] = i;
            }
        }

        char[] array = new char[s.Length];
        int length = 0;
        for (int i = 0, d = 1; i < s.Length; i += d)
        {
            if (s[i] == '(' ||
                s[i] == ')')
            {
                i = pair[i];
                d = -d;
            }
            else
            {
                array[length++] = s[i];
            }
        }

        return new string(array, 0, length);
    }
}
// @lc code=end

