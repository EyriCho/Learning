/*
 * @lc app=leetcode id=1007 lang=csharp
 *
 * [1007] Minimum Domino Rotations For Equal Row
 */

// @lc code=start
public class Solution {
    public int MinDominoRotations(int[] A, int[] B) {
        int Check(int target)
        {
            int t = 0, b = 0;
            
            for (int i = 0; i < tops.Length; i++)
            {
                if (tops[i] != target && bottoms[i] != target)
                {
                    return -1;
                }
                else if (tops[i] != target)
                {
                    t++;
                }
                else if (bottoms[i] != target)
                {
                    b++;
                }
            }
            
            return Math.Min(t, b);
        }
        
        var rotation = Check(tops[0]);
        
        if (rotation == -1)
        {
            return Check(bottoms[0]);
        }
        
        return rotation;
    }
}
// @lc code=end

