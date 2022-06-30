/*
 * @lc app=leetcode id=844 lang=csharp
 *
 * [844] Backspace String Compare
 */

// @lc code=start
public class Solution {
    public bool BackspaceCompare(string s, string t) {
        string Calc(string str)
        {
            var array = new char[str.Length];
            var count = 0;
            
            foreach (var c in str)
            {
                if (c == '#')
                {
                    if (count > 0)
                    {
                        count--;
                    }
                }
                else
                {
                    array[count++] = c;
                }
            }
            
            return new string(array, 0, count);
        }
        
        return Calc(s) == Calc(t);
    }
}
// @lc code=end

