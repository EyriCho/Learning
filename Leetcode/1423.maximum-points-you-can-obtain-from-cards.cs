/*
 * @lc app=leetcode id=1423 lang=csharp
 *
 * [1423] Maximum Points You Can Obtain from Cards
 */

// @lc code=start
public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        var sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += cardPoints[i];
        }
        if (k == cardPoints.Length)
            return sum;
        
        var result = sum;
        for (int i = k - 1; i > -1; i--)
        {
            sum = sum - cardPoints[i] + cardPoints[cardPoints.Length - k + i];
            result = Math.Max(sum, result);
        }
        
        return result;
    }
}
// @lc code=end

