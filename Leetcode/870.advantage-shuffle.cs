/*
 * @lc app=leetcode id=870 lang=csharp
 *
 * [870] Advantage Shuffle
 */

// @lc code=start
public class Solution {
    public int[] AdvantageCount(int[] A, int[] B) {
        var temp = new (int, int)[B.Length];
        var result = new int[A.Length];
        
        for (int i = 0; i < A.Length; i++)
            temp[i] = (B[i], i);
        
        Array.Sort(A);
        Array.Sort(temp, (l, r) => l.Item1 - r.Item1);
        
        int l = 0, r = A.Length - 1;
        for (int i = A.Length - 1; i >= 0; i--)
        {
            var (v, index) = temp[i];
            if (A[r] > v)
                result[index] = A[r--];
            else
                result[index] = A[l++];
        }
        
        return result;
    }
}
// @lc code=end

