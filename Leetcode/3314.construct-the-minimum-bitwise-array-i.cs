/*
 * @lc app=leetcode id=3314 lang=csharp
 *
 * [3314] Construct the Minimum Bitwise Array I
 */

// @lc code=start
public class Solution {
    public int[] MinBitwiseArray(IList<int> nums) {
        int[] result = new int[nums.Count];
        int p = 0;

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == 2)
            {
                result[i] = -1;
                continue;
            }

            p = 0;
            while ((nums[i] & (1 << p)) > 0)
            {
                p++;
            }

            result[i] = nums[i] ^ (1 << (p - 1));
        }

        return result;
    }
}
// @lc code=end

