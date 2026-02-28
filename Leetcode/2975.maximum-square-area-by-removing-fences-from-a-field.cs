/*
 * @lc app=leetcode id=2975 lang=csharp
 *
 * [2975] Maximum Square Area by Removing Fences From a Field
 */

// @lc code=start
public class Solution {
    public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences) {
        HashSet<int> GetSides(int maxFence, int[] fences)
        {
            Array.Sort(fences);
            HashSet<int> set = new ();

            for (int i = 0; i < fences.Length; i++)
            {
                set.Add(fences[i] - 1);

                for (int j = 0; j < i; j++)
                {
                    set.Add(fences[i] - fences[j]);
                }

                set.Add(maxFence - fences[i]);
            }
            set.Add(maxFence - 1);

            return set;
        }

        HashSet<int> hSides = GetSides(m, hFences),
            vSides = GetSides(n, vFences);
        
        long maxSide = 0L;
        foreach (int h in hSides)
        {
            if (vSides.Contains(h))
            {
                maxSide = Math.Max(maxSide, h);
            }
        }

        return maxSide == 0L ? -1 : (int)(maxSide * maxSide % 1_000_000_007L);
    }
}
// @lc code=end

