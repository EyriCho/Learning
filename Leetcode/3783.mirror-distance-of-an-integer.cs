/*
 * @lc app=leetcode id=3783 lang=csharp
 *
 * [3783] Mirror Distance of an Integer
 */

// @lc code=start
public class Solution {
    public int MirrorDistance(int n) {
        int reverse = 0,
            num = n;
        while (num > 0)
        {
            reverse = reverse * 10 + num % 10;
            num /= 10;
        }

        return Math.Abs(reverse - n);
    }
}
// @lc code=end

