/*
 * @lc app=leetcode id=1334 lang=csharp
 *
 * [1334] Find the City With the Smallest Number of Neighbors at a Threshold Distance
 */

// @lc code=start
public class Solution {
    public int FindTheCity(int n, int[][] edges, int distanceThreshold) {
        int[,] distance = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    continue;
                }

                distance[i, j] = 1_000_000;
            }
        }

        foreach (int[] edge in edges)
        {
            distance[edge[0], edge[1]] = edge[2];
            distance[edge[1], edge[0]] = edge[2];
        }
        
        for (int k = 0; k < n; k++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    distance[i, j] = Math.Min(distance[i, j], distance[i, k] + distance[k, j]);
                }
            }
        }

        int min = n,
            count = 0,
            result = 0;

        for (int i = 0; i < n; i++)
        {
            count = 0;
            for (int j = 0; j < n; j++)
            {
                if (distance[i, j] <= distanceThreshold)
                {
                    count++;
                }
            }

            if (count <= min)
            {
                min = count;
                result = i;
            }
        }

        return result;
    }
}
// @lc code=end

