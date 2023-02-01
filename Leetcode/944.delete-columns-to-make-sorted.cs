/*
 * @lc app=leetcode id=944 lang=csharp
 *
 * [944] Delete Columns to Make Sorted
 */

// @lc code=start
public class Solution {
    public int MinDeletionSize(string[] strs) {
        var result = 0;
        
        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int r = 1; r < strs.Length; r++)
            {
                if (strs[r][i] < strs[r - 1][i])
                {
                    result++;
                    break;
                }
            }
        }

        return result;
    }
}
// @lc code=end

