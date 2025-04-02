/*
 * @lc app=leetcode id=3174 lang=csharp
 *
 * [3174] Clear Digits
 */

// @lc code=start
public class Solution {
    public string ClearDigits(string s) {
        Stack<char> stack = new ();

        foreach (char c in s)
        {
            if (c >= '0' && c <= '9')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        char[] array = new char[stack.Count];
        int i = array.Length - 1;
        while (stack.Count > 0)
        {
            array[i--] = stack.Pop();
        }

        return new string(array);
    }
}
// @lc code=end

