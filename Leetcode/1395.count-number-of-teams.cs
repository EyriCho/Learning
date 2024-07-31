/*
 * @lc app=leetcode id=1395 lang=csharp
 *
 * [1395] Count Number of Teams
 */

// @lc code=start
public class Solution {
    public int NumTeams(int[] rating) {
        int[] max = new int[rating.Length],
            min = new int[rating.Length];
        
        int result = 0;
        for (int i = 1; i < rating.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (rating[i] > rating[j])
                {
                    max[i]++;
                    result += max[j];
                }
                else if (rating[i] < rating[j])
                {
                    min[i]++;
                    result += min[j];
                }
            }
        }

        return result;
    }
}
// @lc code=end

