/*
 * @lc app=leetcode id=1598 lang=csharp
 *
 * [1598] Crawler Log Folder
 */

// @lc code=start
public class Solution {
    public int MinOperations(string[] logs) {
        int level = 0;
        foreach (string log in logs)
        {
            if (log[1] == '.')
            {
                level = Math.Max(level - 1, 0);
            }
            else if (log[0] != '.')
            {
                level++;
            }
        }

        return level;
    }
}
// @lc code=end

