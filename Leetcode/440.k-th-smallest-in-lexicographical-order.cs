/*
 * @lc app=leetcode id=440 lang=csharp
 *
 * [440] K-th Smallest in Lexicographical Order
 */

// @lc code=start
public class Solution {
    public int FindKthNumber(int n, int k) {
        long current = 1L,
            counts = 0L;
        k--;

        long Count(long left)
        {
            long right = left + 1L,
                result = 0L;
            while (left <= n)
            {
                result += Math.Min(n + 1, right) - left;
                left *= 10L;
                right *= 10L;
            }
            return result;
        }

        while (k > 0)
        {
            counts = Count(current);
            if (counts <= k)
            {
                current += 1L;
                k -= (int)counts;
            }
            else
            {
                current *= 10L;
                k--;
            }
        }
        return (int)current;
    }
}
// @lc code=end

