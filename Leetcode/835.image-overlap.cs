/*
 * @lc app=leetcode id=835 lang=csharp
 *
 * [835] Image Overlap
 */

// @lc code=start
public class Solution {
    public int LargestOverlap(int[][] A, int[][] B) {
        List<int> aPos = new List<int>();
        List<int> bPos = new List<int>();
        int[] shift = new int[(A.Length * 101) * 2];
        
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < A[0].Length; j++)
            {
                if (A[i][j] == 1)
                    aPos.Add(i * 100 + j);
                if (B[i][j] == 1)
                    bPos.Add(i * 100 + j);
            }
        }
        
        int result = 0;
        foreach (var a in aPos)
        {
            foreach (var b in bPos)
            {
                var diff = b - a + A.Length * 101;
                shift[diff]++;
                if (shift[diff] > result)
                    result = shift[diff];
            }
        }
        return result;
    }
}
// @lc code=end

