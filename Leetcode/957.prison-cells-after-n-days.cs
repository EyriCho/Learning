/*
 * @lc app=leetcode id=957 lang=csharp
 *
 * [957] Prison Cells After N Days
 */

// @lc code=start
public class Solution {
    public int[] PrisonAfterNDays(int[] cells, int N) {
        var count = N % 14;
        if (count == 0) count = 14;
        for (int i = 0; i < count; i++)
        {
            int[] nextState = new int[8];
            for (int j = 1; j < 7; j++)
            {
                nextState[j] = cells[j - 1] == cells[j + 1] ? 1 : 0;
            }
            cells = nextState;
        }
        return cells;
    }
}
// @lc code=end

