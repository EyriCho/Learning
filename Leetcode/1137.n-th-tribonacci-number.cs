/*
 * @lc app=leetcode id=1137 lang=csharp
 *
 * [1137] N-th Tribonacci Number
 */

// @lc code=start
public class Solution {
    public int Tribonacci(int n) {
        if (n < 2)
            return n;
        if (n == 2)
            return 1;
        
        int prev1 = 0, prev2 = 1, prev3 = 1;
        int i = 2, result = 1;
        while (i < n)
        {
            result = prev1 + prev2 + prev3;
            prev1 = prev2;
            prev2 = prev3;
            prev3 = result;
            i++;
        }
        return result;
    }
}
// @lc code=end

