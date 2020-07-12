/*
 * @lc app=leetcode id=977 lang=csharp
 *
 * [977] Squares of a Sorted Array
 */

// @lc code=start
public class Solution {
    public int[] SortedSquares(int[] A) {
        int[] result = new int[A.Length];
        int left = 0, right = A.Length - 1;
        int leftSquare = A[left] * A[left];
        int rightSquare = A[right] * A[right];
        int i = A.Length - 1;
        for (; i >= 0; i--)
        {
            if (leftSquare > rightSquare)
            {
                result[i] = leftSquare;
                left++;
                if (left < A.Length)
                    leftSquare = A[left] * A[left];
            }
            else
            {
                result[i] = rightSquare;
                right--;
                if (right >= 0)
                    rightSquare = A[right] * A[right];
            }
        }
        
        return result;
    }
}
// @lc code=end

