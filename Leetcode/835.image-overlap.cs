/*
 * @lc app=leetcode id=835 lang=csharp
 *
 * [835] Image Overlap
 */

// @lc code=start
public class Solution {
    public int LargestOverlap(int[][] img1, int[][] img2) {
        List<(int x, int y)> list1 = new (),
            list2 = new ();

        for (int i = 0; i < img1.Length; i++)
        {
            for (int j = 0; j < img1.Length; j++)
            {
                if (img1[i][j] == 1)
                {
                    list1.Add((i, j));
                }
                if (img2[i][j] == 1)
                {
                    list2.Add((i, j));
                }
            }
        }

        int[,] dCount = new int[img1.Length << 1, img1.Length << 1];
        int dx = 0, dy = 0,
            result = 0;
        foreach ((int x1, int y1) in list1)
        {
            foreach ((int x2, int y2) in list2)
            {
                dx = x2 - x1 + img1.Length;
                dy = y2 - y1 + img1.Length;
                result = Math.Max(result, ++dCount[dx, dy]);
            }
        }

        return result;
    }
}
// @lc code=end

