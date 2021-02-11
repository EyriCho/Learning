/*
 * @lc app=leetcode id=1673 lang=csharp
 *
 * [1673] Find the Most Competitive Subsequence
 */

// @lc code=start
public class Solution {
     public int[] MostCompetitive(int[] nums, int k) {
        if (nums.Length == k)
            return nums;
        
        int[] result = new int[k];
        int b = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            while (b >= 0 && result[b] > nums[i] &&
                  b + nums.Length - i >= k)
                b--;
            if (b + 1 < k)
                result[++b] = nums[i];
        }
        
        return result;
    }
}
// @lc code=end

