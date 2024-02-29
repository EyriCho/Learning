/*
 * @lc app=leetcode id=2125 lang=csharp
 *
 * [2125] Number of Laser Beams in a Bank
 */

// @lc code=start
public class Solution {
    public int NumberOfBeams(string[] bank) {
        int prevRow = 0,
            rowCount = 0,
            result = 0;

        for (int i = 0; i < bank.Length; i++)
        {
            rowCount = 0;

            foreach (char c in bank[i])
            {
                rowCount += c - '0';
            }

            if (rowCount != 0)
            {
                result += rowCount * prevRow;
                prevRow = rowCount;
            }
        }
        
        return result;
    }
}
// @lc code=end

