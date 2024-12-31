/*
 * @lc app=leetcode id=3152 lang=csharp
 *
 * [3152] Special Array II 
 */

// @lc code=start
public class Solution {
    public bool[] IsArraySpecial(int[] nums, int[][] queries) {
        bool[] result = new bool[queries.Length];

        int[] counts = new int[nums.Length];
        
        for (int i = 1; i < nums.Length; i++)
        {
            counts[i] = counts[i - 1];
            if ((nums[i] + nums[i - 1]) % 2 == 1)
            {
                counts[i]++;
            }
        }

        for (int i = 0; i < queries.Length; i++)
        {
            result[i] = (counts[queries[i][1]] - counts[queries[i][0]]) == (queries[i][1] - queries[i][0]);
        }

        return result;
    }
}
// @lc code=end

