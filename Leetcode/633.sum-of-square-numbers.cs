/*
 * @lc app=leetcode id=633 lang=csharp
 *
 * [633] Sum of Square Numbers
 */

// @lc code=start
public class Solution {
    public bool JudgeSquareSum(int c) {
        int l = 0, r = (int)Math.Sqrt(c);
        var set = new HashSet<long>();
        while (l <= r)
        {
            var sum = l * l + r * r;
            if (sum == c)
                return true;
            else if (sum < c)
                l++;
            else 
                r--;
        }
        return false;
    }
}
// @lc code=end

