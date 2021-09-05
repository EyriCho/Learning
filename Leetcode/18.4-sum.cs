/*
 * @lc app=leetcode id=18 lang=csharp
 *
 * [18] 4Sum
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var result = new List<IList<int>>();
        
        Array.Sort(nums);
        
        for (int i = nums.Length - 1; i > 2; i--)
        {
            if (i < nums.Length - 1 && nums[i] == nums[i + 1])
                continue;
            for (int j = 0; j < i - 2; j++)
            {
                if (j > 0 && nums[j] == nums[j - 1])
                    continue;
                int l = j + 1, r = i - 1;
                while (l < r)
                {
                    long sum = nums[i] + nums[j] + nums[l] + nums[r];
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[l], nums[r] });
                        while (l < r && nums[l] == nums[l + 1])
                            l++;
                        while (l < r && nums[r] == nums[r - 1])
                            r--;
                        l++;
                        r--;
                    }
                    else if (sum < target)
                        l++;
                    else
                        r--;
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

