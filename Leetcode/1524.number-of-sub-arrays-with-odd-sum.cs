/*
 * @lc app=leetcode id=1524 lang=csharp
 *
 * [1524] Number of Sub-arrays With Odd Sum
 */

// @lc code=start
public class Solution {
    public int NumOfSubarrays(int[] arr) {
        int result = 0,
            odd = 0,
            even = 0,
            temp = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                result = (result + odd) % 1_000_000_007;
                even += 1;
            }
            else
            {
                result = (result + even + 1) % 1_000_000_007;
                temp = odd;
                odd = even + 1;
                even = temp;
            }
        }

        return result;
    }
}
// @lc code=end

