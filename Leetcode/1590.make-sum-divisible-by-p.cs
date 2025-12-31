/*
 * @lc app=leetcode id=1590 lang=csharp
 *
 * [1590] Make Sum Divisible by P
 */

// @lc code=start
public class Solution {
    public int MinSubarray(int[] nums, int p) {
        int remain = 0,
            current = 0,
            diff = 0,
            result = int.MaxValue;
        
        foreach (int num in nums)
        {
            remain = (remain + num) % p;
        }
        if (remain == 0)
        {
            return 0;
        }

        Dictionary<int, int> dict = new ();
        dict[0] = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            current = (current + nums[i]) % p;
            diff = (current - remain + p) % p;
            if (dict.ContainsKey(diff))
            {
                result = Math.Min(result, i - dict[diff]);

            }
            dict[current] = i;
        }

        return result < nums.Length ? result : -1;
    }
}
// @lc code=end

