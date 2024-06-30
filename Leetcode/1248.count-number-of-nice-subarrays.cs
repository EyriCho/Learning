/*
 * @lc app=leetcode id=1248 lang=csharp
 *
 * [1248] Count Number of Nice Subarrays
 */

// @lc code=start
public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        int Most(int c)
        {
            int oddCount = 0,
                r = 0,
                rst = 0;

            for (int l = 0; l < nums.Length; l++)
            {
                while (r < nums.Length && oddCount <= c)
                {
                    if (nums[r] % 2 == 1)
                    {
                        if (oddCount == c)
                        {
                            break;
                        }
                        oddCount++;
                    }
                    r++;
                }

                rst += r - l;

                if (nums[l] % 2 == 1)
                {
                    oddCount--;
                }
            }

            return rst;
        }

        return Most(k) - Most(k - 1);
    }
}
// @lc code=end

