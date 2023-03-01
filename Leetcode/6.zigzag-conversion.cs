/*
 * @lc app=leetcode id=6 lang=csharp
 *
 * [6] Zigzag Conversion
 */

// @lc code=start
public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1)
        {
            return s;
        }

        var round = numRows * 2 - 2;
        var array = new char[s.Length];
        var index = 0;

        int row = 0;
        while (row < numRows)
        {
            for (int i = row; i < s.Length; i += round)
            {
                array[index++] = s[i];
                var temp = i + round - 2 * row;

                if (row != 0 &&
                    row != numRows - 1 &&
                    temp < s.Length)
                {
                    array[index++] = s[temp];
                }
            }
            row++;
        }

        return new string(array);
    }
}
// @lc code=end

