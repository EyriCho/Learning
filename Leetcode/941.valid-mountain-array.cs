/*
 * @lc app=leetcode id=941 lang=csharp
 *
 * [941] Valid Mountain Array
 */

// @lc code=start
public class Solution {
    public bool ValidMountainArray(int[] A) {
        if (A == null || A.Length < 3) return false;
        
        if (A[1] <= A[0]) return false;
        bool isIncrease = true;
        for (int i = 1; i < A.Length; i++)
        {
            if (isIncrease)
            {
                if (A[i] == A[i - 1])
                    return false;
                else if (A[i] < A[i - 1])
                    isIncrease = false;
            }
            else
            {
                if (A[i] >= A[i - 1]) return false;
            }
        }
        if (isIncrease) return false;
        
        return true;
    }
}
// @lc code=end

