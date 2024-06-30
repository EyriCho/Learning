/*
 * @lc app=leetcode id=1052 lang=csharp
 *
 * [1052] Grumpy Bookstore Owner
 */

// @lc code=start
public class Solution {
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {
        int period = 0,
            maxPeriod = 0,
            satisfied = 0;

        for (int i = 0; i < customers.Length; i++)
        {
            if (i >= minutes &&
                grumpy[i - minutes] == 1)
            {
                period -= customers[i - minutes];
            }

            if (grumpy[i] == 0)
            {
                satisfied += customers[i];
            }
            else
            {
                period += customers[i];
                maxPeriod = Math.Max(maxPeriod, period);
            }
        }

        return satisfied + maxPeriod;
    }
}
// @lc code=end

