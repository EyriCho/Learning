/*
 * @lc app=leetcode id=1980 lang=csharp
 *
 * [1980] Find Unique Binary String
 */

// @lc code=start
public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        char[] array = new char[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            array[i] = nums[i][i] == '0' ? '1' : '0';
        }

        return new string(array);
    }
}
// @lc code=end

