/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        
        var dict = new Dictionary<char, char> 
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };
        
        foreach(var c in s)
        {
            if (!dict.ContainsKey(c))
                stack.Push(c);
            else
            {
                if (stack.Count == 0)
                    return false;
                
                var prev = stack.Pop();
                if (dict[c] != prev)
                    return false;
            }
        }
        
        return stack.Count == 0;
    }
}
// @lc code=end

