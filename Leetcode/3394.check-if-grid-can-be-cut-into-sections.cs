/*
 * @lc app=leetcode id=3394 lang=csharp
 *
 * [3394] Check if Grid can be Cut into Sections
 */

// @lc code=start
public class Solution {
    public bool CheckValidCuts(int n, int[][] rectangles) {
        List<int[]> resemble = new ();

        Array.Sort(rectangles, (a, b) => a[0].CompareTo(b[0]));
        resemble.Add(rectangles[0]);
        for (int i = 1; i < rectangles.Length; i++)
        {
            if (rectangles[i][0] < resemble[^1][2])
            {
                resemble[^1][2] = Math.Max(resemble[^1][2], rectangles[i][2]);
            }
            else
            {
                resemble.Add(rectangles[i]);
            }
        }

        if (resemble.Count > 2)
        {
            return true;
        }

        Array.Sort(rectangles, (a, b) => a[1].CompareTo(b[1]));
        resemble.Clear();
        resemble.Add(rectangles[0]);
        for (int i = 1; i < rectangles.Length; i++)
        {
            if (rectangles[i][1] < resemble[^1][3])
            {
                resemble[^1][3] = Math.Max(resemble[^1][3], rectangles[i][3]);
            }
            else
            {
                resemble.Add(rectangles[i]);
            }
        }

        return resemble.Count > 2;
    }
}
// @lc code=end

