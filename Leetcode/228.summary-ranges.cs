/*
 * @lc app=leetcode id=228 lang=csharp
 *
 * [228] Summary Ranges
 */

// @lc code=start
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var result = new List<string>();
        if (nums.Length == 0)
            return result;
        int last = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > 1 + nums[i - 1])
            {
                if (last == nums[i - 1])
                    result.Add($"{last}");
                else
                    result.Add($"{last}->{nums[i - 1]}");
                last = nums[i];
            }
        }
        if (last == nums[nums.Length - 1])
            result.Add($"{last}");
        else
            result.Add($"{last}->{nums[nums.Length - 1]}");
        
        return result;
    }
}
// @lc code=end

