/*
 * @lc app=leetcode id=2038 lang=csharp
 *
 * [2038] Remove Colored Pieces if Both Neighbors are the Same Color
 */

// @lc code=start
public class Solution {
    public bool WinnerOfGame(string colors) {
        int a = 0, b = 0;

        for (int i = 1; i < colors.Length - 1; i++)
        {
            if (colors[i] == 'A')
            {
                if (colors[i - 1] == 'A' && colors[i + 1] == 'A')
                {
                    a++;
                }
            }
            else
            {
                if (colors[i - 1] == 'B' && colors[i + 1] == 'B')
                {
                    b++;
                }
            }
        }

        return a > b;
    }
}
// @lc code=end

