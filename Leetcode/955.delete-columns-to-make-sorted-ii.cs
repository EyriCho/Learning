/*
 * @lc app=leetcode id=955 lang=csharp
 *
 * [955] Delete Columns to Make Sorted II
 */

// @lc code=start
public class Solution {
    public int MinDeletionSize(string[] strs) {
        bool[] rows = new bool[strs.Length];
        bool notValid = false;
        int result = 0;

        for (int j = 0; j < strs[0].Length; j++)
        {
            notValid = false;
            for (int i = 1; i < strs.Length; i++)
            {
                if (rows[i])
                {
                    continue;
                }

                if (strs[i][j] < strs[i - 1][j])
                {
                    notValid = true;
                    break;
                }
            }

            if (notValid)
            {
                result++;
                continue;
            }

            for (int i = 1; i < strs.Length; i++)
            {
                if (rows[i])
                {
                    continue;
                }

                if (strs[i][j] > strs[i - 1][j])
                {
                    rows[i] = true;
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

