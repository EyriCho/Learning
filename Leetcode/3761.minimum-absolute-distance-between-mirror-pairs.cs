/*
 * @lc app=leetcode id=3761 lang=csharp
 *
 * [3761] Minimum Absolute Distance Between Mirror Pairs
 */

// @lc code=start
public class Solution {
    public int MinMirrorPairDistance(int[] nums) {
        Dictionary<int, int> dict = new ();
        int reverse = 0,
            origin = 0,
            min = nums.Length ;
        for (int i = 0; i < nums.Length; i++)
        {
            origin = nums[i];
            reverse = 0;
            while (origin > 0)
            {
                reverse = reverse * 10 + origin % 10;
                origin /= 10;
            }

            if (dict.ContainsKey(nums[i]))
            {
                min = Math.Min(min, i - dict[nums[i]]);
            }
            dict[reverse] = i;
        }

        return min == nums.Length ? -1 : min;
    }
}
// @lc code=end

