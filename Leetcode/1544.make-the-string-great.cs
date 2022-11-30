/*
 * @lc app=leetcode id=1544 lang=csharp
 *
 * [1544] Make The String Great
 */

// @lc code=start
public class Solution {
    public string MakeGood(string s) {
        var stack = new Stack<char>();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Count == 0)
            {
                stack.Push(s[i]);
            }
            else
            {
                var diff = s[i] - stack.Peek();
                if (diff == 32 || diff == -32)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
        }
        
        var array = new char[stack.Count];
        for (int i = stack.Count - 1; i >= 0; i--)
        {
            array[i] = stack.Pop();
        }
        
        return new string(array);
    }
}
// @lc code=end

