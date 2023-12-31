/*
 * @lc app=leetcode id=1758 lang=csharp
 *
 * [1758] Minimum Changes To Make Alternating Binary String
 */

// @lc code=start
public class Solution {
    public int MinOperations(string s) {
        int operations = 0,
            expect = 0;

        foreach (char c in s)
        {
            if (c - '0' != expect)
            {
                operations++;
            }
            
            expect = 1 - expect;
        }

        return Math.Min(operations, s.Length - operations);
    }
}
// @lc code=end

