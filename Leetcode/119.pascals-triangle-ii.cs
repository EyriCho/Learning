/*
 * @lc app=leetcode id=119 lang=csharp
 *
 * [119] Pascal's Triangle II
 */

// @lc code=start
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var length = rowIndex + 1;
        var result = new int[length];
        result[0] = 1;
        if (rowIndex == 0) return result;
        int i = 0;
        for (i = 1; i < length; i++)
        {
            for (int j = i; j > 0; j--)
            {
                result[j] += result[j - 1];
            }
        }
        
        
        for (i = length / 2 + 1; i < length; i++)
        {
            result[i] = result[length - 1 - i];        
        }
        
        return result;
    }
}
// @lc code=end

