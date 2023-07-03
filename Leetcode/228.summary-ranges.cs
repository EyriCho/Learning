/*
 * @lc app=leetcode id=228 lang=csharp
 *
 * [228] Summary Ranges
 */

// @lc code=start
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        int i = 0, start = 0;
        var result = new List<string>();
        while (i < nums.Length)
        {
            start = i++;
            while (i < nums.Length && nums[i] - nums[i - 1] == 1)
            {
                i++;
            }
            
            if (i - start > 1)
            {
                result.Add($"{nums[start]}->{nums[i - 1]}");            
            }
            else
            {
                result.Add(nums[start].ToString());
            }
        }
        
        return result;
    }
}
// @lc code=end

