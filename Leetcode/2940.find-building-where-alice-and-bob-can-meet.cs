/*
 * @lc app=leetcode id=2940 lang=csharp
 *
 * [2940] Find Building Where Alice and Bob Can Meet
 */

// @lc code=start
public class Solution {
    public int[] LeftmostBuildingQueries(int[] heights, int[][] queries) {
        List<(int, int)>[] left = new List<(int, int)>[heights.Length];
        for (int i = 0; i < heights.Length; i++)
        {
            left[i] = new ();
        }

        int[] result = new int[queries.Length];
        Array.Fill(result, -1);
        int temp = 0;
        for (int i = 0; i < queries.Length; i++)
        {
            if (queries[i][0] > queries[i][1])
            {
                queries[i][0] ^= queries[i][1];
                queries[i][1] ^= queries[i][0];
                queries[i][0] ^= queries[i][1];
            }

            if (queries[i][0] == queries[i][1] ||
                heights[queries[i][0]] < heights[queries[i][1]])
            {
                result[i] = queries[i][1];
            }
            else
            {
                left[queries[i][1]].Add((heights[queries[i][0]], i));
            }
        }

        PriorityQueue<(int, int), int> queue = new ();
        for (int i = 0; i < heights.Length; i++)
        {
            while (queue.Count > 0 &&
                heights[i] > queue.Peek().Item1)
            {
                result[queue.Dequeue().Item2] = i;
            }

            foreach ((int, int) l in left[i])
            {
                queue.Enqueue(l, l.Item1);
            }
        }

        return result;
    }
}
// @lc code=end

