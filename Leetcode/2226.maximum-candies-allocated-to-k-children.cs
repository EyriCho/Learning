/*
 * @lc app=leetcode id=2226 lang=csharp
 *
 * [2226] Maximum Candies Allocated to K Children
 */

// @lc code=start
public class Solution {
    public int MaximumCandies(int[] candies, long k) {
        long total = 0;
        foreach (int c in candies)
        {
            total += c;
        }

        if (total < k)
        {
            return 0;
        }

        bool Allocate(int candy)
        {
            if (candy == 0)
            {
                return true;
            }

            long childs = 0L;
            foreach (int c in candies)
            {
                childs += c / candy;
            }

            return childs >= k;
        }

        int l = 0,
            m = 0,
            r = (int)(total / k + 1L);
        
        while (l < r)
        {
            m = l + ((r - l) >> 1);
            if (Allocate(m))
            {
                l = m + 1;
            }
            else
            {
                r = m;
            }
        }

        return l - 1;
    }
}
// @lc code=end

