/*
 * @lc app=leetcode id=3027 lang=csharp
 *
 * [3027] Find the Number of Ways to Place People II
 */

// @lc code=start
public class Solution {
    public int NumberOfPairs(int[][] points) {
        Array.Sort(points, (a, b) => a[0].Equals(b[0]) ? a[1].CompareTo(b[1]) : b[0].CompareTo(a[0]));

        int result = 0,
            y = 0;

        for (int i = 0; i < points.Length; i++)
        {
            y = int.MaxValue;
            for (int j = i + 1; j < points.Length; j++)
            {
                if (points[j][1] >= points[i][1] && 
                    y > points[j][1])
                {
                    result++;
                    y = points[j][1];
                }
            }
        }
        
        return result;
    }
}
// @lc code=end

