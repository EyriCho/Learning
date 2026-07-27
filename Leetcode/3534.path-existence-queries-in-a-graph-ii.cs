/*
 * @lc app=leetcode id=3534 lang=csharp
 *
 * [3534] Path Existence Queries in a Graph II
 */

// @lc code=start
public class Solution {
    public int[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries) {
        int[] idx = Enumerable.Range(0, n).ToArray();

        Array.Sort(idx, (a, b) => nums[a].CompareTo(nums[b]));

        int maxBit = 32 - BitOperations.LeadingZeroCount((uint)n);
        int[,] jump = new int[n, maxBit];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < maxBit; j++)
            {
                jump[i, j] = -1;
            }
        }

        for (int i = n - 1, j = n - 1; i >= 0; i--)
        {
            if (j > i)
            {
                j = i;
            }
            while (j > 0 && nums[idx[i]] - nums[idx[j - 1]] <= maxDiff)
            {
                jump[idx[--j], 0] = idx[i];
            }
        }

        for (int j = 1; j < maxBit; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (jump[i, j - 1] != -1)
                {
                    jump[i, j] = jump[jump[i, j - 1], j - 1];
                }
            }
        }

        int u = 0, v = 0;
        int[] result = new int[queries.Length];
        for (int q = 0; q < queries.Length; q++)
        {
            if (queries[q][0] == queries[q][1])
            {
                result[q] = 0;
                continue;
            }
            u = queries[q][0];
            v = queries[q][1];
            if (nums[u] == nums[v])
            {
                result[q] = 1;
                continue;
            }

            if (nums[u] > nums[v])
            {
                (u, v) = (v, u);
            }

            for (int j = maxBit - 1; j >= 0; j--)
            {
                if (jump[u, j] != -1 &&
                    nums[jump[u, j]] <= nums[v])
                {
                    u = jump[u, j];
                    result[q] += 1 << j;
                }
            }

            if (nums[v] - nums[u] > maxDiff)
            {
                result[q] = -1;
            }
            else if (nums[v] > nums[u])
            {
                result[q]++;
            }
        }

        return result;
    }
}
// @lc code=end

