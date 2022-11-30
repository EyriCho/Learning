/*
 * @lc app=leetcode id=1323 lang=csharp
 *
 * [1323] Maximum 69 Number
 */

// @lc code=start
public class Solution {
    public int Maximum69Number (int num) {
        var temp = num;
        int pos = 1, adjust = 0;
        while (temp > 0)
        {
            if (temp % 10 == 6)
            {
                adjust = pos * 3;
            }
            temp /= 10;
            pos *= 10;
        }
        
        return num + adjust;
    }
}
// @lc code=end

