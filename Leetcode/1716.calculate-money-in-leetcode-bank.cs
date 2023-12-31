/*
 * @lc app=leetcode id=1716 lang=csharp
 *
 * [1716] Calculate Money in Leetcode Bank
 */

// @lc code=start
public class Solution {
    public int TotalMoney(int n) {
        int weeks = n / 7,
            left = n % 7;

        return 28 * weeks + (weeks - 1) * 7 * weeks / 2 +
            (left + 1) * left / 2 + weeks * left;
    }
}
// @lc code=end

