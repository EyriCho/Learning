/*
 * @lc app=leetcode id=2657 lang=csharp
 *
 * [2657] Find the Prefix Common Array of Two Arrays
 */

// @lc code=start
public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        int[] result = new int[A.Length],
            records = new int[A.Length];
        int count = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (++records[A[i] - 1] == 2)
            {
                count++;
            }
            if (++records[B[i] - 1] == 2)
            {
                count++;
            }
            
            result[i] = count;
        }

        return result;
    }
}
// @lc code=end

