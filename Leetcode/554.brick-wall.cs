/*
 * @lc app=leetcode id=554 lang=csharp
 *
 * [554] Brick Wall
 */

// @lc code=start
public class Solution {
    public int LeastBricks(IList<IList<int>> wall) {
        var count = 0;
        var dict = new Dictionary<int, int>();
        
        foreach (var row in wall)
        {
            var sum = 0;
            for (int i = row.Count - 1; i > 0; i--)
            {
                sum += row[i];
                if (dict.ContainsKey(sum))
                    dict[sum]++;
                else
                    dict[sum] = 1;
                
                count = Math.Max(dict[sum], count);
            }
        }
        
        return wall.Count - count;
    }
}
// @lc code=end

