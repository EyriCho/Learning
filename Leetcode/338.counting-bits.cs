/*
 * @lc app=leetcode id=338 lang=csharp
 *
 * [338] Counting Bits
 */

// @lc code=start
public class Solution {
    public int[] CountBits(int n) {
        var result = new int[n + 1];
        
        int i = 1, dup = 1;
        while (i <= n)
        {
            int last = i + dup - 1;
            while (i <= last && i <= n)
            {
                result[i] = result[i - dup] + 1;
                i++;
            }
            dup <<= 1;
        }
        
        return result;
    }
}
// @lc code=end

