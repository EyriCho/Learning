/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>() {
            new List<int> { 1 }
        };
        
        for (int row = 1; row < numRows; row++)
        {
            var list = new List<int>(row + 1);
            var prev = result[row - 1];
            list.Add(1);
            for (int j = 1; j < row; j++)
            {
                list.Add(prev[j - 1] + prev[j]);
            }
            list.Add(1);
            result.Add(list);
        }
        
        return result;
    }
}
// @lc code=end

