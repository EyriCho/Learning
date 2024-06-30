/*
 * @lc app=leetcode id=826 lang=csharp
 *
 * [826] Most Profit Assigning Work
 */

// @lc code=start
public class Solution {
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker) {
        Array.Sort(worker);
        Array.Sort(difficulty, profit);

        int i = 0,
            j = 0,
            max = 0,
            result = 0;

        while (i < worker.Length)
        {
            if (j < profit.Length && difficulty[j] <= worker[i])
            {
                max = Math.Max(profit[j], max);
                j++;
            }
            else
            {
                result += max;
                i++;
            }
        }

        return result;
    }
}
// @lc code=end

