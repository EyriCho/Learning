/*
 * @lc app=leetcode id=1249 lang=csharp
 *
 * [1249] Minimum Remove to Make Valid Parentheses
 */

// @lc code=start
public class Solution {
    public string MinRemoveToMakeValid(string s) {
        Stack<(char, int)> stack = new ();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ')')
            {
                stack.Push((')', i));
            }
            else if (s[i] == '(')
            {
                if (stack.Count == 0 ||
                    stack.Peek().Item1 == '(')
                {
                    stack.Push(('(', i));
                }
                else
                {
                    stack.Pop();
                }
            }
        }
        
        if (stack.Count() == 0)
        {
            return s;
        }
        
        char[] array = new char[s.Length - stack.Count()];
        (_, int toRemove) = stack.Pop();
        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i != toRemove)
            {
                array[j++] = s[i];
                continue;
            }
            
            if (stack.Count > 0)
            {
                (_, toRemove) = stack.Pop();
            }
        }
        
        return new string(array);
    }
}
// @lc code=end

