/*
 * @lc app=leetcode id=1861 lang=csharp
 *
 * [1861] Rotating the Box
 */

// @lc code=start
public class Solution {
    public char[][] RotateTheBox(char[][] box) {
        char[][] result = new char[boxGrid[0].Length][];
        for (int i = 0; i < boxGrid[0].Length; i++)
        {
            result[i] = new char[boxGrid.Length];
            Array.Fill(result[i], '.');
        }

        int lastStone = 0;
        for (int i = 0; i < boxGrid.Length; i++)
        {
            lastStone = boxGrid[0].Length - 1;
            for (int j = boxGrid[0].Length - 1; j >= 0; j--)
            {
                if (boxGrid[i][j] == '*')
                {
                    result[j][boxGrid.Length - 1 - i] = '*';
                    lastStone = j - 1;
                }
                else if (boxGrid[i][j] == '#')
                {
                    result[lastStone][boxGrid.Length - 1 - i] = '#';
                    lastStone--;
                }
            }
        }

        return result;
    }
}
// @lc code=end

