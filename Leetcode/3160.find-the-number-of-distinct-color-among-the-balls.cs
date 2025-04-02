/*
 * @lc app=leetcode id=3160 lang=csharp
 *
 * [3160] Find the Number of Distinct Color Among the Balls
 */

// @lc code=start
public class Solution {
    public int[] QueryResults(int limit, int[][] queries) {
        int count = 0,
            current = 0,
            color = 0;
        int[] result = new int[queries.Length];
        Dictionary<int, int> dict = new (),
            balls = new ();
        
        for (int i = 0; i < result.Length; i++)
        {
            balls.TryGetValue(queries[i][0], out color);
            if (color > 0)
            {
                dict.TryGetValue(color, out current);
                if (current == 1)
                {
                    count--;
                }
                dict[color] = current - 1;
            }

            color = queries[i][1];
            dict.TryGetValue(color, out current);
            if (current == 0)
            {
                count++;
            }
            dict[color] = current + 1;

            balls[queries[i][0]] = color;
            result[i] = count;
        }

        return result;
    }
}
// @lc code=end

