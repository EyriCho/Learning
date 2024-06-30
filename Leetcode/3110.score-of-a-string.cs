/*
 * @lc app=leetcode id=3110 lang=csharp
 *
 * [3110] Score of a String
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int sum=0;
        for(int i = 0; i < s.Length - 1; i++){
            sum += Math.Abs(s[i] - s[i+1]);
        }
        return sum;
    }
}
// @lc code=end

