/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution {
    public int Reverse(int x) {
        if (x == 0)
        {
            return 0;
        }

        long temp = 0;
        while (x != 0)
        {
            temp = temp * 10 + x % 10;
            x /= 10;
        }
        
        return temp > int.MaxValue || temp < int.MinValue ? 0 : (int)temp;
    }
}
// @lc code=end

