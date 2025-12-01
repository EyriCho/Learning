/*
 * @lc app=leetcode id=1015 lang=csharp
 *
 * [1015] Smallest Integer Divisible by K
 */

// @lc code=start
public class Solution {
    public int SmallestRepunitDivByK(int k) {
        if (k % 2 == 0 ||
            k % 5 == 0)
        {
            return -1;
        }

        int remain = 0,
            length = 1;

        while (length <= k)
        {
            remain = (remain * 10 + 1) % k;
            if (remain == 0)
            {
                return length;
            }
            length++;
        }
        
        return -1;
    }
}
// @lc code=end

