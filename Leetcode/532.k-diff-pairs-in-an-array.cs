/*
 * @lc app=leetcode id=532 lang=csharp
 *
 * [532] K-diff Pairs in an Array
 */

// @lc code=start
public class Solution {
    public int FindPairs(int[] nums, int k) {
        Array.Sort(nums);
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == nums[i])
                {
                    if (k == 0)
                        result++;
                    while (j < nums.Length && nums[j] == nums[i])
                    {
                        i++;
                        j++;
                    }
                    if (j == nums.Length)
                        break;
                }
                if (nums[j] == nums[i] + k)
                {
                    result++;
                    break;
                }
                else if (nums[j] > nums[i] + k)
                    break;
            }
        }
        
        return result;
    }
}
// @lc code=end

