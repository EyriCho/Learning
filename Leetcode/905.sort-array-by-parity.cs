/*
 * @lc app=leetcode id=905 lang=csharp
 *
 * [905] Sort Array By Parity
 */

// @lc code=start
public class Solution {
    public int[] SortArrayByParity(int[] A) {
        int l = 0, r = A.Length - 1;
        while (l < r)
        {
            while (l < A.Length && (A[l] & 1) == 0) l++;
            while (r > 0 && (A[r] & 1) != 0) r--;
            if (l < r)
            {
                var temp = A[l];
                A[l] = A[r];
                A[r] = temp;
                l++;
                r--;
            }
        }
        return A;
    }
}
// @lc code=end

