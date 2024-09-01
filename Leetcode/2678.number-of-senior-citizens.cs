/*
 * @lc app=leetcode id=2678 lang=csharp
 *
 * [2678] Number of Senior Citizens
 */

// @lc code=start
public class Solution {
    public int CountSeniors(string[] details) {
        int age = 0,
            result = 0;
        foreach (string detail in details)
        {
            age = (detail[11] - '0') * 10 + (detail[12] - '0');
            result += age > 60 ? 1 : 0;
        }
        return result;
    }
}
// @lc code=end

