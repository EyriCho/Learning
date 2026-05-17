/*
 * @lc app=leetcode id=1674 lang=csharp
 *
 * [1674] Minimum Moves to Make Array Complementary
 */

// @lc code=start
public class Solution {
    public int MinMoves(int[] nums, int limit) {
        int[] diffArray = new int[limit * 2 + 2];
        diffArray[2] = nums.Length;

        int min = 0, max = 0;
        for (int l = 0, r = nums.Length - 1; l < r; l++, r--)
        {
            min = Math.Min(nums[l], nums[r]);
            max = Math.Max(nums[l], nums[r]);

            diffArray[min + 1] -= 1;
            diffArray[max + limit + 1] += 1;
            diffArray[nums[l] + nums[r]] -= 1;
            diffArray[nums[l] + nums[r] + 1] += 1;
        }

        int result = nums.Length,
            current = 0;
        for (int s = 2; s <= 2 * limit; s++)
        {
            current += diffArray[s];
            result = Math.Min(result, current);
        }

        return result;
    }
}
// @lc code=end

