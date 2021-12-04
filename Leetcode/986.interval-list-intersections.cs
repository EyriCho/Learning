/*
 * @lc app=leetcode id=986 lang=csharp
 *
 * [986] Interval List Intersections
 */

// @lc code=start
public class Solution {
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) {
        int f = 0, s = 0;
        var list = new List<int[]>();
        while (f < firstList.Length && s < secondList.Length)
        {
            int start = Math.Max(firstList[f][0], secondList[s][0]),
                end = Math.Min(firstList[f][1], secondList[s][1]);
            
            if (start <= end)
                list.Add(new int[] { start, end });
            
            if (firstList[f][1] < secondList[s][1])
                f++;
            else
                s++;
        }
        
        return list.ToArray();
    }
}
// @lc code=end

