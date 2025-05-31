/*
 * @lc app=leetcode id=733 lang=csharp
 *
 * [733] Flood Fill
 */

// @lc code=start
public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if (image[sr][sc] == color)
        {
            return image;
        }

        int[,] ds = new int[,] {
            { 0, 1 },
            { 1, 0 },
            { 0, -1 },
            { -1, 0 },
        };

        int origin = image[sr][sc],
            x = 0, y = 0,
            i = 0, j = 0;
        Queue<(int, int)> queue = new ();
        queue.Enqueue((sr, sc));

        while (queue.Count > 0)
        {
            (x, y) = queue.Dequeue();
            image[x][y] = color;

            for (int k = 0; k < 4; k++)
            {
                i = x + ds[k, 0];
                j = y + ds[k, 1];

                if (i >= 0 && i < image.Length &&
                    j >= 0 && j < image[0].Length &&
                    image[i][j] == origin)
                {
                    queue.Enqueue((i, j));
                }
            }
        }
        return image;
    }
}
// @lc code=end

