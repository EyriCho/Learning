/*
 * @lc app=leetcode id=1846 lang=csharp
 *
 * [1846] Maximum Element After Decreasing and Rearranging
 */

// @lc code=start
public class Solution {
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr) {
        Array.Sort(arr);

        int prev = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            prev = Math.Min(prev + 1, arr[i]);
        }

        return prev;
    }
}
// @lc code=end

