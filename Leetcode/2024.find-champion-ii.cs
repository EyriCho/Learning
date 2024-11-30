/*
 * @lc app=leetcode id=2924 lang=csharp
 *
 * [2924] Find Champion II
 */

// @lc code=start
public class Solution {
    public int FindChampion(int n, int[][] edges) {
        int[] lose = new int[n];

        foreach (int[] edge in edges)
        {
            lose[edge[1]]++;
        }

        int champion = -1;
        for (int i = 0; i < n; i++)
        {
            if (lose[i] > 0)
            {
                continue;
            }

            if (champion > -1)
            {
                return -1;
            }
            champion = i;
        }

        return champion;
    }
}
// @lc code=end

