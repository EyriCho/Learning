/*
 * @lc app=leetcode id=1833 lang=csharp
 *
 * [1833] Maximum Ice Cream Bars
 */

// @lc code=start
public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        int[] counts = new int[100_001];
        foreach (int cost in costs)
        {
            counts[cost]++;
        }

        int t = 0,
            result = 0;
        for (int i = 1; i < counts.Length; i++)
        {
            if (counts[i] == 0)
            {
                continue;
            }

            t = coins / i;
            if (t > counts[i])
            {
                result += counts[i];
                coins -= counts[i] * i;
            }
            else
            {
                result += t;
                break;
            }
        }

        return result;
    }
}
// @lc code=end

