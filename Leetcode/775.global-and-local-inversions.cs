/*
 * @lc app=leetcode id=775 lang=csharp
 *
 * [775] Global and Local Inversions
 */

// @lc code=start
public class Solution {
    public bool IsIdealPermutation(int[] A) {
        int max = 0, last = A.Length - 2;
        
        for (int i = 0; i < last; i++)
        {
            max = Math.Max(max, A[i]);
            if (max > A[i + 2])
                return false;
        }
        return true;
    }
}
// @lc code=end

