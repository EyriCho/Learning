/*
 * @lc app=leetcode id=850 lang=csharp
 *
 * [850] Rectangle Area II
 */

// @lc code=start
public class Solution {
    public int RectangleArea(int[][] rectangles) {
        var pieces = new List<int[]>();
        
        void Cut(int[] rec, int index)
        {
            if (index >= pieces.Count)
            {
                pieces.Add(rec);
                return;
            }
            
            int[] prev = pieces[index];
            if (rec[2] <= prev[0] || rec[0] >= prev[2] ||
               rec[3] <= prev[1] || rec[1] >= prev[3])
            {    
                Cut(rec, index + 1);
                return;
            }
            
            if (rec[0] < prev[0])
                Cut(new int[] { rec[0], rec[1], prev[0], rec[3] }, index + 1);
            
            if (rec[2] > prev[2])
                Cut(new int[] { prev[2], rec[1], rec[2], rec[3] }, index + 1);
            
            if (rec[1] < prev[1])
                Cut(new int[] {
                        Math.Max(rec[0], prev[0]),
                        rec[1],
                        Math.Min(rec[2], prev[2]),
                        prev[1]
                    },
                    index + 1);
            
            if (rec[3] > prev[3])
                Cut(new int[] {
                        Math.Max(rec[0], prev[0]),
                        prev[3],
                        Math.Min(rec[2], prev[2]),
                        rec[3]
                    },
                    index + 1);
        }
        
        foreach (var rectangle in rectangles)
            Cut(rectangle, 0);
        
        long result = 0L;
        foreach (var r in pieces)
            result = (result + (long)(r[3] - r[1]) * (r[2] - r[0])) % 1_000_000_007;
        
        return (int)result;
    }
}
// @lc code=end

