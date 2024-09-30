/*
 * @lc app=leetcode id=1310 lang=csharp
 *
 * [1310] XOR Queries of a Subarray
 */

// @lc code=start
public class Solution {
    public int[] XorQueries(int[] arr, int[][] queries) {
        for (int i = 1; i < arr.Length; i++)
        {
            arr[i] ^= arr[i - 1];
        }

        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            if (queries[i][0] == 0)
            {
                result[i] = arr[queries[i][1]];
            }
            else
            {
                result[i] = arr[queries[i][0] - 1] ^ arr[queries[i][1]];
            }
        }
        return result;
    }
}
// @lc code=end

