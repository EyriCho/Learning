/*
 * @lc app=leetcode id=2392 lang=csharp
 *
 * [2392] Build a Matrix With Conditions
 */

// @lc code=start
public class Solution {
    public int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions) {
        
        IList<int> Sequence(int[][] conditions)
        {
            List<int> rst = new();
            List<int>[] maps = new List<int>[k + 1];
            int[] degrees = new int[k + 1];

            foreach (int[] condition in conditions)
            {
                if (maps[condition[0]] == null)
                {
                    maps[condition[0]] = new ();
                }
                maps[condition[0]].Add(condition[1]);
                degrees[condition[1]]++;
            }

            Queue<int> queue = new ();
            for (int i = 1; i <= k; i++)
            {
                if (degrees[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            while (queue.Count > 0)
            {
                int num = queue.Dequeue();
                rst.Add(num);
                if (maps[num] != null)
                {
                    foreach (int next in maps[num])
                    {
                        if (--degrees[next] == 0)
                        {
                            queue.Enqueue(next);
                        }
                    }
                }
            }

            return rst;
        }

        IList<int> rowSequence = Sequence(rowConditions);
        IList<int> colSequence = Sequence(colConditions);
        if (rowSequence.Count != k || colSequence.Count != k)
        {
            return new int[0][];
        }

        int[][] result = new int[k][];
        for (int i = 0; i < k; i++)
        {
            result[i] = new int[k];
        }

        int row = 0,
            col = 0;
        for (int i = 1; i <= k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (rowSequence[j] == i)
                {
                    row = j;
                    break;
                }
            }

            for (int j = 0; j < k; j++)
            {
                if (colSequence[j] == i)
                {
                    col = j;
                    break;
                }
            }

            result[row][col] = i;
        }

        return result;
    }
}
// @lc code=end

