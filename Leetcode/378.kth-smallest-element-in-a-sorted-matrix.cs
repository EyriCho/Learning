/*
 * @lc app=leetcode id=378 lang=csharp
 *
 * [378] Kth Smallest Element in a Sorted Matrix
 */

// @lc code=start
public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
        int low = matrix[0][0],
            high = matrix[matrix.Length - 1][matrix[0].Length - 1];
        
        while (low <= high)
        {
            var mid = (low + high) / 2;
            int count = 0, b = matrix.Length - 1;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                while (b >= 0 && matrix[b][i] > mid)
                    b--;
                count += b + 1;
            }
            if (count < k)
                low = mid + 1;
            else
                high = mid - 1;
        }
        
        return low;
    }
}
// @lc code=end

