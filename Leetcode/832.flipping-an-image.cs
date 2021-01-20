/*
 * @lc app=leetcode id=832 lang=csharp
 *
 * [832] Flipping an Image
 */

// @lc code=start
public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        for (int i = 0; i < A.Length; i++)
        {
            int l = 0, r = A.Length - 1;
            while (l <= r)
            {
                var temp = A[i][l] ^ 1;
                A[i][l] = A[i][r] ^ 1;
                A[i][r] = temp;
                ++l;
                --r;
            }
        }
        
        return A;
    }
}
// @lc code=end

