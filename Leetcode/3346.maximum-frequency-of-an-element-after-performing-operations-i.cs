/*
 * @lc app=leetcode id=3346 lang=csharp
 *
 * [3346] Maximum Frequency of an Element After Performing Operations I
 */

// @lc code=start
public class Solution {
    public int MaxFrequency(int[] nums, int k, int numOperations) {
        int max = 0;
        foreach (int num in nums)
        {
            max = Math.Max(max, num);
        }
        max += k + 2;

        int[] count = new int[max];
        foreach (int num in nums)
        {
            count[num]++;
        }
        for (int i = 1; i < max; i++)
        {
            count[i] += count[i - 1];
        }

        int result = 0,
            left = 0,
            right = 0,
            freq = 0,
            total = 0;
        for (int i = 1; i < max; i++)
        {
            left = Math.Max(1, i - k);
            right = Math.Min(max - 1, i + k);
            total = count[right] - count[left - 1];
            freq = count[i] - count[i - 1];

            result = Math.Max(result, freq + Math.Min(numOperations, total - freq));
        }

        return result;
    }
}
// @lc code=end

