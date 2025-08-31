/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> result = new ();
        List<int> prev = new () { 1 };
        result.Add(prev);
        
        for (int row = 1; row < numRows; row++)
        {
            List<int> list = new (row + 1);
            list.Add(1);
            for (int i = 1; i < row; i++)
            {
                list.Add(prev[i - 1] + prev[i]);
            }
            list.Add(1);
            result.Add(list);
            prev = list;
        }
        
        return result;
    }
}
// @lc code=end

