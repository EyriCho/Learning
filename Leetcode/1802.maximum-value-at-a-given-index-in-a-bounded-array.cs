/*
 * @lc app=leetcode id=1802 lang=csharp
 *
 * [1802] Maximum Value at a Given Index in a Bounded Array
 */

// @lc code=start
public class Solution {
    public int MaxValue(int n, int index, int maxSum) {
        bool IsSatisfy(long num)
        {
            int left = index,
                right = n - index - 1;

            var sum = 0L;
            if (num - 1 >= left)
            {
                sum += (num - 1 + num - left) * left / 2;
            }
            else
            {
                sum += (num - 1) * num / 2 + (left - num + 1);
            }

            if (num > right)
            {
                sum += (num - 1 + num - right) * right / 2;
            }
            else
            {
                sum += (num - 1) * num / 2 + (right - num + 1);
            }

            return sum + num <= maxSum;
        }

        int l = 1, r = maxSum;
        while (l < r)
        {
            var m = (l + r + 1) >> 1;
            if (IsSatisfy(m))
            {
                l = m;
            }
            else
            {
                r = m - 1;
            }
        }

        return l;
    }
}
// @lc code=end

