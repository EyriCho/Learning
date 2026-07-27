/*
 * @lc app=leetcode id=3532 lang=csharp
 *
 * [3532] Path Existence Queries in a Graph I
 */

// @lc code=start
public class Solution {
    public bool[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries) {
        int[] groups = new int[n];
        for (int i = 0; i < n; i++)
        {
            groups[i] = i;
        }

        int l = 0, r = 0;
        while (l < n)
        {
            r = l + 1;

            while (r < n &&
                nums[r] - nums[r - 1] <= maxDiff)
            {
                groups[r++] = groups[l];
            }

            l = r;
        }

        bool[] result = new bool[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            result[i] = groups[queries[i][0]] == groups[queries[i][1]];
        }

        return result;
    }
}
// @lc code=end

