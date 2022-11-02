/*
 * @lc app=leetcode id=835 lang=csharp
 *
 * [835] Image Overlap
 */

// @lc code=start
public class Solution {
    public int LargestOverlap(int[][] img1, int[][] img2) {
        var aNodes = new List<int>();
        var bNodes = new List<int>();
        var vectors = new int[img1.Length * 101 * 2];
        
        for (int i = 0; i < img1.Length; i++)
        {
            for (int j = 0; j < img1.Length; j++)
            {
                if (img1[i][j] == 1)
                {
                    aNodes.Add(i * 100 + j);
                }
                
                if (img2[i][j] == 1)
                {
                    bNodes.Add(i * 100 + j);
                }
            }
        }
        
        int result = 0;
        foreach (var aNode in aNodes)
        {
            foreach (var bNode in bNodes)
            {
                var v = bNode - aNode + img1.Length * 101;
                vectors[v]++;
                result = Math.Max(vectors[v], result);
            }
        }
        return result;
    }
}
// @lc code=end

