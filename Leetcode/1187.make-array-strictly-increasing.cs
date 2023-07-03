/*
 * @lc app=leetcode id=1187 lang=csharp
 *
 * [1187] Make Array Strictly Increasing
 */

// @lc code=start
public class Solution {
    public int MakeArrayIncreasing(int[] arr1, int[] arr2) {
        if (arr1.Length == 0)
        {
            return 0;
        }

        Array.Sort(arr2);

        // dp means after swith i(row)th num of the first j(column) num,
        // the minimum num you can put at j position.
        var dp = new int[arr1.Length + 1, arr1.Length + 1];
        for (int i = 0; i <= arr1.Length; i++)
        {
            for (int j = 0; j <= arr1.Length; j++)
            {
                dp[i, j] = 1_000_000_001;
            }
        }
        dp[0, 0] = int.MinValue;
        for (int j = 1; j <= arr1.Length; j++)
        {
            for (int i = 0; i <= j; i++)
            {
                if (arr1[j - 1] > dp[i, j - 1])
                {
                    dp[i, j] = arr1[j - 1];
                }

                if (i > 0)
                {
                    var index = Array.BinarySearch(arr2, dp[i - 1, j - 1] + 1);
                    if (index < 0)
                    {
                        index = ~index;
                    }

                    if (index < arr2.Length)
                    {
                        dp[i, j] = Math.Min(dp[i, j], arr2[index]);
                    }
                }

                if (j == arr1.Length && dp[i, j] != 1_000_000_001)
                {
                    return i;
                }
            }
        }

        return -1;
    }
}
// @lc code=end

