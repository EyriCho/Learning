/*
 * @lc app=leetcode id=1007 lang=csharp
 *
 * [1007] Minimum Domino Rotations For Equal Row
 */

// @lc code=start
public class Solution {
    public int MinDominoRotations(int[] A, int[] B) {
        int rotation = Check(A[0], A, B);
        
        if (rotation == -1)
            return Check(B[0], B, A);
        else
            return rotation;
    }
    
    private int Check(int target, int[] A, int[] B)
    {
        int a = 0, b = 0;
        
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] != target && B[i] != target)
                return -1;
            else if (A[i] != target)
                a++;
            else if (B[i] != target)
                b++;
        }
        
        return a < b ? a : b;
    }}
// @lc code=end

