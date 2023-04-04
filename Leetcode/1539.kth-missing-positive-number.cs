/*
 * @lc app=leetcode id=1539 lang=csharp
 *
 * [1539] Kth Missing Positive Number
 */

// @lc code=start
public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int prev = 0;

        foreach (var num in arr)
        {
            var missing = num - prev - 1;
            if (k > missing)
            {
                k -= missing;
            }
            else
            {
                return prev + k;
            }
            prev = num;
        }

        return prev + k;
    }
}
// @lc code=end

