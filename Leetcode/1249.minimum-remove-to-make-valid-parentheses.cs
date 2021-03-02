/*
 * @lc app=leetcode id=1249 lang=csharp
 *
 * [1249] Minimum Remove to Make Valid Parentheses
 */

// @lc code=start
public class Solution {
    public string MinRemoveToMakeValid(string s) {
        var stack = new Stack<(char, int)>();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ')')
            {
                stack.Push((')', i));
            }
            else if (s[i] == '(')
            {
                if (stack.Count == 0)
                {
                    stack.Push(('(', i));
                }
                else
                {
                    var (c, _) = stack.Peek();
                    if (c == ')')
                        stack.Pop();
                    else
                        stack.Push(('(', i));
                }
            }
        }
        
        //return new string(stack.Select(pair => pair.Item1).ToArray());
        
        if (stack.Count == 0)
            return s;
        var list = new List<char>();
        var (_, j) = stack.Pop();
        for (int i = 0; i < s.Length; i++)
        {
            if (i == j)
            {
                if (stack.Count > 0)
                    j = stack.Pop().Item2;
            }
            else
            {
                list.Add(s[i]);
            }
        }
        
        return new string(list.ToArray());
    }
}
// @lc code=end

