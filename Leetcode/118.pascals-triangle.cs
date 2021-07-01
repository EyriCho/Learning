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
        
        for (int i = 1; i < numRows; i++)
        {
            var list = new List<int>(i + 1);
            var prev = result[i - 1];
            list.Add(1);
            for (int j = 1; j < i; j++)
                list.Add(prev[j - 1] + prev[j]);
            list.Add(1);
            result.Add(list);
        }
        
        return result;
    }
}
// @lc code=end

