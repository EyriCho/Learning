/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            if (nums[i] > 0) break;
            
            int start = i + 1, last = nums.Length - 1;
            while (start < last)
            {
                int a = nums[i];
                int b = nums[start];
                int c = nums[last];
                if (a + b + c == 0)
                {
                    result.Add(new List<int> {a, b, c});
                    while (start < last && nums[start] == nums[start + 1])
                        start++;
                    while (start < last && nums[last] == nums[last - 1])
                        last--;
                    start++;
                    last--;
                }
                else if (b + c < -a)
                    start++;
                else
                    last--;
            }
            
        }
        
        return result;
    }
}
// @lc code=end

