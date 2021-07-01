/*
 * @lc app=leetcode id=1047 lang=csharp
 *
 * [1047] Remove All Adjacent Duplicates In String
 */

// @lc code=start
public class Solution {
    public string RemoveDuplicates(string s) {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (stack.Count > 0 && stack.Peek() == c)
                stack.Pop();
            else
                stack.Push(c);
        }
        
        var array = new char[stack.Count];
        var count = stack.Count;
        while (--count > -1)
            array[count] = stack.Pop();
        return new string(array);
    }
}
// @lc code=end

