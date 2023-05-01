/*
 * @lc app=leetcode id=2390 lang=csharp
 *
 * [2390] Removing Stars From a String
 */

// @lc code=start
public class Solution {
    public string RemoveStars(string s) {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c != '*')
            {
                stack.Push(c);
            }
            else
            {
                stack.Pop();
            }
        }

        var array = new char[stack.Count];
        int i = stack.Count - 1;
        while (i >= 0)
        {
            array[i--] = stack.Pop();
        }

        return new string(array);
    }
}
// @lc code=end

