/*
 * @lc app=leetcode id=1544 lang=csharp
 *
 * [1544] Make The String Great
 */

// @lc code=start
public class Solution {
    public string MakeGood(string s) {
        Stack<char> stack = new ();
        int diff = 0;
        foreach (char c in s)
        {
            if (stack.Count == 0)
            {
                stack.Push(c);
                continue;
            }

            diff = c - stack.Peek();
            if (diff == 32 ||
                diff == -32)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        char[] array = new char[stack.Count];
        for (int i = stack.Count - 1; i >= 0; i--)
        {
            array[i] = stack.Pop();
        }

        return new string(array);
    }
}
// @lc code=end

