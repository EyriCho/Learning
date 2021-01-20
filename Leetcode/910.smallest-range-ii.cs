/*
 * @lc app=leetcode id=910 lang=csharp
 *
 * [910] Smallest Range II
 */

// @lc code=start
public class Solution {
    public int SmallestRangeII(int[] A, int K) {
        Array.Sort(A);
        
        int lastPos = A.Length - 1;
        int left = A[0] + K,
            right = A[lastPos] - K,
            result = A[lastPos] - A[0];
        
        for (int i = 0; i < lastPos; i++)
        {
            int h = Math.Max(right, A[i] + K);
            int l = Math.Min(left, A[i + 1] - K);
            result = Math.Min(result, h - l);
        }
        
        return result;
    }
}
// @lc code=end

