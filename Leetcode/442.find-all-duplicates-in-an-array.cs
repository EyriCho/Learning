/*
 * @lc app=leetcode id=442 lang=csharp
 *
 * [442] Find All Duplicates in an Array
 */

// @lc code=start
public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var index = (nums[i] > 0 ? nums[i] : -nums[i]) - 1;
            
            if (nums[index] > 0)
                nums[index] = -nums[index];
            else
                result.Add(index + 1);
        }
        return result;        
    }
}
// @lc code=end

