/*
 * @lc app=leetcode id=1477 lang=csharp
 *
 * [1477] Find Two Non-overlapping Sub-arrays Each With Target Sum
 */

// @lc code=start
public class Solution {
    public int MinSumOfLengths(int[] arr, int target) {
        int[] prefixMin = new int[arr.Length],
            suffixMin = new int[arr.Length];
        
        int sum = 0,
            min = 0;

        for (int l = 0, r = 0; r < arr.Length; r++)
        {
            sum += arr[r];
            while (l < r && sum > target)
            {
                sum -= arr[l++];
            }

            if (sum == target)
            {
                if (min == 0)
                {
                    min = r - l + 1;
                }
                else
                {
                    min = Math.Min(min, r - l + 1);
                }
            }

            prefixMin[r] = min;
        }

        sum = 0;
        min = 0;
        for (int l = arr.Length - 1, r = arr.Length - 1; l >= 0; l--)
        {
            sum += arr[l];

            while (l < r && sum > target)
            {
                sum -= arr[r--];
            }

            if (sum == target)
            {
                if (min == 0)
                {
                    min = r - l + 1;
                }
                else
                {
                    min = Math.Min(min, r - l + 1);
                }
            }

            suffixMin[l] = min;
        }

        int result = int.MaxValue;
        for (int i = arr.Length - 2; i >= 0; i--)
        {
            if (prefixMin[i] <= 0 ||
                suffixMin[i + 1] <= 0)
            {
                continue;
            }
            result = Math.Min(result, prefixMin[i] + suffixMin[i + 1]);
        }

        return result == int.MaxValue ? -1 : result;
    }
}
// @lc code=end

