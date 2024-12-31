/*
 * @lc app=leetcode id=1760 lang=csharp
 *
 * [1760] Minimum Limit of Balls in a Bag
 */

// @lc code=start
public class Solution {
    public int MinimumSize(int[] nums, int maxOperations) {
        int l = 1,
            r = 0,
            m = 0,
            o = 0;
        foreach (int num in nums)
        {
            r = Math.Max(r, num);
        }
        
        while (l < r)
        {
            m = l + ((r - l) >> 1);
            o = 0;

            foreach (int num in nums)
            {
                o += (num - 1) / m;
            }

            if (o > maxOperations)
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }

        return l;
    }
}
// @lc code=end

