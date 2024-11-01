/*
 * @lc app=leetcode id=2696 lang=csharp
 *
 * [2696] Minimum String Length After Remove Substrings
 */

// @lc code=start
public class Solution {
    public int MinLength(string s) {
        Stack<char> stack = new ();
        foreach (char c in s)
        {
            if (c == 'B' &&
                stack.Count > 0 &&
                stack.Peek() == 'A')
            {
                stack.Pop();
            }
            else if (c == 'D' &&
                stack.Count > 0 &&
                stack.Peek() == 'C')
            {
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count;
    }
}
// @lc code=end

