/*
 * @lc app=leetcode id=1552 lang=csharp
 *
 * [1552] Magnetic Force Between Two Balls
 */

// @lc code=start
public class Solution {
    public int MaxDistance(int[] position, int m) {
        Array.Sort(position);

        bool Check(int force)
        {
            int balls = 1,
                next = position[0] + force;

            for (int i = 1; i < position.Length; i++)
            {
                if (position[i] >= next)
                {
                    balls++;
                    next = position[i] + force;
                }

                if (balls == m)
                {
                    return true;
                }
            }

            return false;
        }

        int l = 1,
            r = position[position.Length - 1] - position[0],
            mid = 0;

        while (l <= r)
        {
            mid = l + (r - l >> 1);
            if (Check(mid))
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        return r;
    }
}
// @lc code=end

