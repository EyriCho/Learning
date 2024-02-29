/*
 * @lc app=leetcode id=2149 lang=csharp
 *
 * [2149] Rearrange Array Elements by Sign
 */

// @lc code=start
public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int[] result = new int[nums.Length];

        int p = 0,
            n = 1;
        foreach (int num in nums)
        {
            if (num > 0)
            {
                result[p] = num;
                p += 2;
            }
            else
            {
                result[n] = num;
                n += 2;
            }
        }

        return result;
    }
}
// @lc code=end

