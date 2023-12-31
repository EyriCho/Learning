/*
 * @lc app=leetcode id=661 lang=csharp
 *
 * [661] Image Smoother
 */

// @lc code=start
public class Solution {
    public int[][] ImageSmoother(int[][] img) {
        int[][] result = new int[img.Length][];
        for (int i = 0; i < img.Length; i++)
        {
            result[i] = new int[img[0].Length];
        }

        int[,] directions = new int[,] {
            { -1, -1 },
            { -1, 0 },
            { -1, 1 },
            { 0, -1 },
            { 0, 0 },
            { 0, 1 },
            { 1, -1 },
            { 1, 0 },
            { 1, 1 },
        };

        for (int i = 0; i < img.Length; i++)
        {
            for (int j = 0; j < img[0].Length; j++)
            {
                int count = 0;
                for (int k = 0; k < 9; k++)
                {
                    int x = i + directions[k, 0],
                        y = j + directions[k, 1];

                    if (x >= 0 && x < img.Length &&
                        y >= 0 && y < img[0].Length)
                    {
                        result[i][j] += img[x][y];
                        count++;
                    }
                }

                result[i][j] /= count;
            }
        }

        return result;
    }
}
// @lc code=end

