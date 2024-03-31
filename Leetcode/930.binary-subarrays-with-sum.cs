/*
 * @lc app=leetcode id=930 lang=csharp
 *
 * [930] Binary Subarrays With Sum
 */

// @lc code=start
public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        int result = 0,
            sum = 0;
        
        Dictionary<int, int> dict= new () 
        {
            { 0, 1 },
        };
        foreach (int num in nums)
        {
            sum += num;

            result += dict.GetValueOrDefault(sum - goal, 0);
            dict[sum] = dict.GetValueOrDefault(sum) + 1;
        }

        return result;
    }
}
// @lc code=end

