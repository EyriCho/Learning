/*
 * @lc app=leetcode id=1304 lang=csharp
 *
 * [1304] Find N Unique Integers Sum up to Zero
 */

// @lc code=start
public class Solution {
    public int[] SumZero(int n) {
        int[] result = new int[n];
        for (int i = n / 2; i > 0; i--)
        {
            result[i - 1] = -i;
            result[n - i] = i;
        }

        return result;
    }
}
// @lc code=end

