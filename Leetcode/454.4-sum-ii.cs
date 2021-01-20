/*
 * @lc app=leetcode id=454 lang=csharp
 *
 * [454] 4Sum II
 */

// @lc code=start
public class Solution {
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D) {
        if (A.Length == 0)
            return 0;
        
        var dict = new Dictionary<int, int>();
        
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < B.Length; j++)
            {
                var sum = -(A[i] + B[j]);
                if (dict.ContainsKey(sum))
                    dict[sum]++;
                else
                    dict[sum] = 1;
            }
        }
        
        int result = 0;
        for (int i = 0; i < C.Length; i++)
        {
            for (int j = 0; j < D.Length; j++)
            {
                var sum = C[i] + D[j];
                if (dict.ContainsKey(sum))
                    result += dict[sum];
            }
        }
        
        
        return result;
    }
}
// @lc code=end

