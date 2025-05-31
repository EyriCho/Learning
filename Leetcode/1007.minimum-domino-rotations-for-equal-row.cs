/*
 * @lc app=leetcode id=1007 lang=csharp
 *
 * [1007] Minimum Domino Rotations For Equal Row
 */

// @lc code=start
public class Solution {
    public int MinDominoRotations(int[] A, int[] B) {
        int Check(int num)
        {
            int t = 0,
                b = 0;
            for (int i = 0; i < tops.Length; i++)
            {
                if (tops[i] != num && bottoms[i] != num)
                {
                    return -1;
                }
                else if (tops[i] != num)
                {
                    t++;
                }
                else if (bottoms[i] != num)
                {
                    b++;
                }
            }

            return Math.Min(b, t);
        }

        int rotate = Check(tops[0]);
        if (rotate == -1)
        {
            rotate = Check(bottoms[0]);
        }

        return rotate;
    }
}
// @lc code=end

