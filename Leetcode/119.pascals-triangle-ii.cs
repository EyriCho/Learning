/*
 * @lc app=leetcode id=119 lang=csharp
 *
 * [119] Pascal's Triangle II
 */

// @lc code=start
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var result = new List<int>(rowIndex + 1);

        for (int i = 0; i <= rowIndex; i++)
        {
            result.Add(1);
            for (int j = i - 1; j > 0; j--)
            {
                result[j] += result[j - 1];
            }
        }

        return result;
    }
}
// @lc code=end

