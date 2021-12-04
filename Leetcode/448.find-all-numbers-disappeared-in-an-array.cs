/*
 * @lc app=leetcode id=448 lang=csharp
 *
 * [448] Find All Numbers Disappeared in an Array
 */

// @lc code=start
public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            while (nums[i] != i + 1 && nums[nums[i] - 1] != nums[i])
            {
                var index = nums[i] - 1;
                nums[i] ^= nums[index];
                nums[index] ^= nums[i];
                nums[i] ^= nums[index];
            }
        }
        
        var result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] != i + 1)
                result.Add(i + 1);
        
        return result;
    }
}
// @lc code=end

