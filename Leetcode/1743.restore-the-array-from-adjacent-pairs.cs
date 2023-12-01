/*
 * @lc app=leetcode id=1743 lang=csharp
 *
 * [1743] Restore the Array From Adjacent Pairs
 */

// @lc code=start
public class Solution {
    public int[] RestoreArray(int[][] adjacentPairs) {
        Dictionary<int, (int, int)> dict = new ();
        foreach (int[] pair in adjacentPairs)
        {
            if (!dict.TryGetValue(pair[0], out (int, int) a0))
            {
                dict[pair[0]] = (pair[1], int.MinValue);
            }
            else
            {
                dict[pair[0]] = (a0.Item1, pair[1]);
            }

            if (!dict.TryGetValue(pair[1], out (int, int) a1))
            {
                dict[pair[1]] = (pair[0], int.MinValue);
            }
            else
            {
                dict[pair[1]] = (a1.Item1, pair[0]);
            }
        }

        int prev = int.MinValue,
            curr = 0;
        foreach (KeyValuePair<int, (int, int)> kv in dict)
        {
            if (kv.Value.Item2 == int.MinValue)
            {
                curr = kv.Key;
                break;
            }
        }

        int[] result = new int[adjacentPairs.Length + 1];
        int i = 0;
        while (i < result.Length)
        {
            result[i] = curr;
            (int a0, int a1) = dict[curr];
            curr = prev == a0 ? a1 : a0;
            prev = result[i++];
        }

        return result;
    }
}
// @lc code=end

