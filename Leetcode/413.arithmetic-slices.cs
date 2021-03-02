/*
 * @lc app=leetcode id=413 lang=csharp
 *
 * [413] Arithmetic Slices
 */

// @lc code=start
public class Solution {
    public int NumberOfArithmeticSlices(int[] A) {
        int result = 0;
        
        int diff = int.MinValue,
            arithmeticCount = 0;
        for (int i = A.Length - 1; i > 0; i--)
        {
            if (A[i - 1] - A[i] == diff)
            {
                arithmeticCount++;
                result += arithmeticCount;
            }
            else
            {
                diff = A[i - 1] - A[i];
                arithmeticCount = 0;
            }
        }
        
        return result;
    }
}
// @lc code=end

