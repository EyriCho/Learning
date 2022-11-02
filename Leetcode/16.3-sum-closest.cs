/*
 * @lc app=leetcode id=16 lang=csharp
 *
 * [16] 3Sum Closest
 */

// @lc code=start
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int result = nums[0] + nums[1] + nums[2];
        int diff = Math.Abs(target - result);
        Array.Sort(nums);
        
        for (int i = nums.Length - 1; i > 1; i--)
        {
            int l = 0, r = i - 1;
            
            while (l < r)
            {
                var sum = nums[i] + nums[l] + nums[r];
                var d = Math.Abs(sum - target);
                if (d < diff)
                {
                    result = sum;
                    diff = d;
                }
                
                if (sum > target)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

