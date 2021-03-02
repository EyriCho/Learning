/*
 * @lc app=leetcode id=991 lang=csharp
 *
 * [991] Broken Calculator
 */

// @lc code=start
public class Solution {
    public int BrokenCalc(int X, int Y) {
        int result = 0;
        while (X < Y)
        {
            if ((Y & 1) == 1)
                Y++;
            else
                Y >>= 1;
            result++;
        }
        
        return result + X - Y;
    }
}
// @lc code=end

