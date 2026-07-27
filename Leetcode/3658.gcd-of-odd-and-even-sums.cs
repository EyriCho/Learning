/*
 * @lc app=leetcode id=3658 lang=csharp
 *
 * [3658] GCD of Odd and Even Sums
 */

// @lc code=start
public class Solution {
    public int GcdOfOddEvenSums(int n) {
        int oddSum = 0,
            evenSum = 0;
        for (int i = 0; i < n; i++)
        {
            oddSum += (i << 1) + 1;
            evenSum += (i << 1) + 2;
        }

        int temp = 0;
        while (oddSum != 0)
        {
            temp = evenSum;
            evenSum = oddSum;
            oddSum = temp % oddSum;
        }

        return evenSum;
    }
}
// @lc code=end

