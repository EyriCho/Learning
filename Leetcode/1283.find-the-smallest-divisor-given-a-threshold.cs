/*
 * @lc app=leetcode id=1283 lang=csharp
 *
 * [1283] Find the Smallest Divisor Given a Threshold
 */

// @lc code=start
public class Solution {
    public int SmallestDivisor(int[] nums, int threshold) {
        int l = 1, r = 1000_000;
        
        while (l < r)
        {
            int total = 0, m = l + (r - l) / 2;
            foreach (var num in nums)
            {
                total += num / m;
                if (num % m != 0)
                    total++;
            }
            
            if (total <= threshold)
                r = m;
            else
                l = m + 1;
        }
        
        return l;
    }
}
// @lc code=end

