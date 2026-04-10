/*
 * @lc app=leetcode id=3661 lang=csharp
 *
 * [3661] Maximum Walls Destroyed by Robots
 */

// @lc code=start
public class Solution {
    public int MaxWalls(int[] robots, int[] distance, int[] walls) {
        (int pos, int dis)[] rArray = new (int, int)[robots.Length + 1];
        for (int i = 0; i < robots.Length; i++)
        {
            rArray[i] = (robots[i], distance[i]);
        }
        rArray[robots.Length] = (1_000_000_001, 0);
        Array.Sort(rArray, (a, b) => a.pos.CompareTo(b.pos));

        Array.Sort(walls);

        int IndexInclude(int num)
        {
            int l = 0, r = walls.Length,
                m = 0;
            
            while (l < r)
            {
                m = (l + r) >> 1;
                if (walls[m] <= num)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            return l;
        }

        int IndexExclude(int num)
        {
            int l = 0, r = walls.Length,
                m = 0;

            while (l < r)
            {
                m = (l + r) >> 1;
                if (walls[m] < num)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }
            return l;
        }

        int Count(int l, int r)
        {
            if (l > r)
            {
                return 0;
            }

            int lIndex = IndexExclude(l);
            int rIndex = IndexInclude(r);
            return rIndex - lIndex;
        }

        int[,] dp = new int[robots.Length, 2];
        dp[0, 0] = Count(rArray[0].pos - rArray[0].dis,
            rArray[0].pos);
        if (robots.Length == 1)
        {
            return Math.Max(dp[0, 0],
                Count(rArray[0].pos,
                    rArray[0].pos + rArray[0].dis));
        }

        dp[0, 1] = Count(rArray[0].pos,
            Math.Min(rArray[1].pos - 1, rArray[0].pos + rArray[0].dis));

        for (int r = 1; r < robots.Length; r++)
        {
            dp[r, 1] = Math.Max(dp[r - 1, 0], dp[r - 1, 1]) +
                Count(rArray[r].pos,
                    Math.Min(rArray[r + 1].pos - 1, rArray[r].pos + rArray[r].dis));
            
            int lStart = Math.Max(rArray[r - 1].pos + 1, rArray[r].pos - rArray[r].dis),
                lEnd = rArray[r].pos,
                overlapStart = lStart,
                overlapEnd = Math.Min(rArray[r - 1].pos + rArray[r - 1].dis, rArray[r].pos - 1);
            dp[r, 0] = dp[r - 1, 0] +
                Count(lStart, lEnd);
            dp[r, 0] = Math.Max(dp[r, 0],
                dp[r - 1, 1] +
                    Count(lStart, lEnd) -
                    Count(overlapStart, overlapEnd));
        }

        return Math.Max(dp[robots.Length - 1, 0], dp[robots.Length - 1, 1]);
    }
}
// @lc code=end

