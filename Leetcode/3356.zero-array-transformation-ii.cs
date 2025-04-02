/*
 * @lc app=leetcode id=3356 lang=csharp
 *
 * [3356] Zero Array Transformation II
 */

// @lc code=start
public class Solution {
    public int MinZeroArray(int[] nums, int[][] queries) {
        int[] array = new int[nums.Length + 1];
        int current = 0;
        bool IsTransforable(int k)
        {
            Array.Fill(array, 0);
            for (int i = 0; i < k; i++)
            {
                array[queries[i][0]] += queries[i][2];
                array[queries[i][1] + 1] -= queries[i][2];
            }

            int current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                current += array[i];
                if (current < nums[i])
                {
                    return false;
                }
            }
            return true;
        }

        int l = 0,
            m = 0,
            r = queries.Length + 1;

        while (l < r)
        {
            m = (l + r) >> 1;
            if (IsTransforable(m))
            {
                r = m;
            }
            else
            {
                l = m + 1;
            }
        }

        return l == queries.Length + 1 ? -1 : l;
    }
}
// @lc code=end

