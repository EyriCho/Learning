/*
 * @lc app=leetcode id=135 lang=csharp
 *
 * [135] Candy
 */

// @lc code=start
public class Solution {
    public int Candy(int[] ratings) {
        int peak = 0, down = 0, up = 0,
            result = 1;
        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                peak = ++up;
                down = 0;
                result += up + 1;
            }
            else if (ratings[i] < ratings[i - 1])
            {
                up = 0;
                result += ++down;
                if (down > peak)
                {
                    result += 1;
                }
            }
            else
            {
                peak = up = down = 0;
                result++;
            }
        }
        
        return result;
    }
}
// @lc code=end

