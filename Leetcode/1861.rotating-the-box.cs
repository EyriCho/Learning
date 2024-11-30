/*
 * @lc app=leetcode id=1861 lang=csharp
 *
 * [1861] Rotating the Box
 */

// @lc code=start
public class Solution {
    public char[][] RotateTheBox(char[][] box) {
        char[][] result = new char[box[0].Length][];

        for (int i = 0; i < box[0].Length; i++)
        {
            result[i] = new char[box.Length];
            Array.Fill(result[i], '.');
        }

        int j = 0,
            c = 0,
            line = 0;

        for (int i = 0; i < box.Length; i++)
        {
            line = box.Length - 1 - i;
            j = 0;

            while (j < box[0].Length)
            {
                c = 0;
                while (j < box[0].Length &&
                    box[i][j] != '*')
                {
                    if (box[i][j] == '#')
                    {
                        c++;
                    }
                    j++;
                }

                if (j < box[0].Length)
                {
                    result[j][line] = '*';
                }

                while (c > 0)
                {
                    result[j - c][line] = '#';
                    c--;
                }

                j++;
            }
        }

        return result;
    }
}
// @lc code=end

