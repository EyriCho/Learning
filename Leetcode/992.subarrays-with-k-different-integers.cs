/*
 * @lc app=leetcode id=992 lang=csharp
 *
 * [992] Subarrays with K Different Integers
 */

// @lc code=start
public class Solution {
    public int SubarraysWithKDistinct(int[] nums, int k) {
        int SubarrayMaxNDistinct(int n)
        {
            int l = 0,
                r = 0,
                distinct = 0,
                rst = 0;
            
            Dictionary<int, int> dict = new();
            for (; r < nums.Length; r++)
            {
                dict.TryGetValue(nums[r], out int c);
                if (c == 0)
                {
                    distinct++;
                }
                dict[nums[r]] = c + 1;

                while (distinct > n)
                {
                    if (--dict[nums[l++]] == 0)
                    {
                        distinct--;
                    }
                }

                rst += r - l + 1;
            }

            return rst;
        }

        return SubarrayMaxNDistinct(k) - SubarrayMaxNDistinct(k - 1);
    }
}
// @lc code=end

