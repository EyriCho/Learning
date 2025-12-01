/*
 * @lc app=leetcode id=3001 lang=csharp
 *
 * [3001] Minimum Moves to Capture The Queen
 */

// @lc code=start
public class Solution {
    public int MinMovesToCaptureTheQueen(int a, int b, int c, int d, int e, int f) {
        if (a == e && (a != c || d < Math.Min(b, f) || d > Math.Max(b, f)))
        {
            return 1;
        }

        if (b == f && (b != d || c < Math.Min(a, e) || c > Math.Max(a, e)))
        {
            return 1;
        }

        if (c + d == e + f && (c + d != a + b || a < Math.Min(c, e) || a > Math.Max(c, e)))
        {
            return 1;
        }

        if (c - d == e - f && (c - d != a - b || a < Math.Min(c, e) || a > Math.Max(c, e)))
        {
            return 1;
        }

        return 2;
    }
}
// @lc code=end

