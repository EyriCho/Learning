/*
 * @lc app=leetcode id=2616 lang=csharp
 *
 * [2616] Minimize the Maximum Difference of Pairs
 */

// @lc code=start
public class Solution {
    public int MinimizeMax(int[] nums, int p) {
        if (p == 0)
        {
            return 0;
        }

        Array.Sort(nums);

        bool Check(int diff)
        {
            int prev = 0,
                temp = 0,
                current = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                temp = current;
                if (nums[i] - nums[i - 1] <= diff)
                {
                    temp = Math.Max(temp, prev + 1);
                }

                prev = current;
                current = temp;
            }

            return current >= p;
        }

        int l = 0,
            m = 0,
            r = nums[^1] - nums[0];
        
        while (l < r)
        {
            m = (l + r) >> 1;
            if (Check(m))
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }

        return r;
    }
}
// @lc code=end

