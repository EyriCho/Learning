/*
 * @lc app=leetcode id=2064 lang=csharp
 *
 * [2064] Minimized Maximum of Products Distributed to Any Store
 */

// @lc code=start
public class Solution {
    public int MinimizedMaximum(int n, int[] quantities) {
        int min = 1,
            max = quantities.Max(),
            mid = 0;
        
        bool Fit(int maximum)
        {
            int stores = 0;

            foreach (int quantity in quantities)
            {
                stores += quantity / maximum + (quantity % maximum == 0 ? 0 : 1);
                if (stores > n)
                {
                    return false;
                }
            }

            return true;
        }

        while (min <= max)
        {
            mid = (min + max) >> 1;
            if (Fit(mid))
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return min;
    }
}
// @lc code=end

