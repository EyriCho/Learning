/*
 * @lc app=leetcode id=1331 lang=csharp
 *
 * [1331] Rank Transform of an Array
 */

// @lc code=start
public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        int[] idxes = Enumerable.Range(0, arr.Length).ToArray();
        Array.Sort(idxes, (a, b) => arr[a].CompareTo(arr[b]));
        int[] result = new int[arr.Length];
        int rank = 0, prev = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[idxes[i]] != prev)
            {
                rank++;
            }

            result[idxes[i]] = rank;
            prev = arr[idxes[i]];
        }

        return result;
    }
}
// @lc code=end

