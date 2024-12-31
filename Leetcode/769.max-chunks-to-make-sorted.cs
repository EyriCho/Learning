/*
 * @lc app=leetcode id=769 lang=csharp
 *
 * [769] Max Chunks To Make Sorted
 */

// @lc code=start
public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int result = 0,
            i = 0,
            max = 0;

        while (i < arr.Length)
        {
            max = Math.Max(arr[i], max);

            if (i == max)
            {
                result++;
            }

            i++;
        }

        return result;
    }
}
// @lc code=end

