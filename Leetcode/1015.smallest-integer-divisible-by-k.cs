/*
 * @lc app=leetcode id=1015 lang=csharp
 *
 * [1015] Smallest Integer Divisible by K
 */

// @lc code=start
public class Solution {
    public int SmallestRepunitDivByK(int k) {
        if (k % 2 == 0 || k % 5 == 0)
            return -1;
        
        int length = 1, remainder = 1 % k;
        var set = new HashSet<int>();
        while (remainder > 0 && !set.Contains(remainder))
        {
            remainder = (remainder * 10 + 1) % k;
            length++;
        }
        
        if (remainder == 0)
            return length;
        else
            return -1;
    }
}
// @lc code=end

