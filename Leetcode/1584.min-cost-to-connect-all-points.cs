/*
 * @lc app=leetcode id=1584 lang=csharp
 *
 * [1584] Min Cost to Connect All Points
 */

// @lc code=start
public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        var distance = new int[points.Length];
        Array.Fill(distance, int.MaxValue);
        var visited = new bool[points.Length];
        int result = 0;
        
        for (int i = 0; i < points.Length; i++)
        {
            int cur = -1;
            
            for (int j = 0; j < points.Length; j++)
            {
                if (!visited[j] && (cur == -1 || distance[j] < distance[cur]))
                {
                    cur = j;
                }
            }
            
            if (i > 0)
            {
                result += distance[cur];
            }
            
            visited[cur] = true;
            
            for (int j = 0; j < points.Length; j++)
            {
                if (!visited[j])
                {
                    distance[j] = Math.Min(distance[j],
                        Math.Abs(points[j][0] - points[cur][0]) + Math.Abs(points[j][1] - points[cur][1]));
                }
            }
        }
        
        
        return result;
    }
}
// @lc code=end

