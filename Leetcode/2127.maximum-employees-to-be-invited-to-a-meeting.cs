/*
 * @lc app=leetcode id=2127 lang=csharp
 *
 * [2127] Maximum Employees to Be Invited to a Meeting
 */

// @lc code=start
public class Solution {
    public int MaximumInvitations(int[] favorite) {
        int[] degrees = new int[favorite.Length],
            depths = new int[favorite.Length];
        foreach (int f in favorite)
        {
            degrees[f]++;
        }

        Queue<int> queue = new ();
        for (int i = 0; i < degrees.Length; i++)
        {
            depths[i] = 1;
            if (degrees[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        int c = 0,
            p = 0;
        while (queue.Count > 0)
        {
            c = queue.Dequeue();
            p = favorite[c];
            depths[p] = depths[c] + 1;
            if (--degrees[p] == 0)
            {
                queue.Enqueue(p);
            }
        }

        int ring = 0,
            maxRing = 0,
            chain = 0;

        for (int i = 0; i < degrees.Length; i++)
        {
            if (degrees[i] == 0)
            {
                continue;
            }

            degrees[i] = 0;
            ring = 1;
            p = favorite[i];
            while (p != i)
            {
                degrees[p] = 0;
                ring++;
                p = favorite[p];
            }

            if (ring == 2)
            {
                chain += depths[i] + depths[favorite[i]];
            }
            else
            {
                maxRing = Math.Max(maxRing, ring);
            }
        }

        return Math.Max(maxRing, chain);
    }
}
// @lc code=end

