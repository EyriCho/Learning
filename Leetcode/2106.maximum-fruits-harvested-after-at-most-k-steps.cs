/*
 * @lc app=leetcode id=2106 lang=csharp
 *
 * [2106] Maximum Fruits Harvested After at Most K Steps
 */

// @lc code=start
public class Solution {
    public int MaxTotalFruits(int[][] fruits, int startPos, int k) {
        int l = 0,
            sum = 0,
            result = 0;

        int MinSteps(int left, int right)
        {
            int goLeft = Math.Abs(startPos - left);
            int goRight = Math.Abs(right - startPos);
            return Math.Min(goLeft, goRight) + (right - left);
        }
        
        for (int r = 0; r < fruits.Length; r++)
        {
            sum += fruits[r][1];

            while (l <= r && MinSteps(fruits[l][0], fruits[r][0]) > k)
            {
                sum -= fruits[l++][1];
            }

            result = Math.Max(result, sum);
        }

        return result;
    }
}
// @lc code=end

