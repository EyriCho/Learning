/*
 * @lc app=leetcode id=2225 lang=csharp
 *
 * [2225] Find Players With Zero or Two Losses
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        var result = new List<IList<int>>();
        result.Add(new List<int>());
        result.Add(new List<int>());
        var dict = new SortedDictionary<int, int>();
        
        foreach (var match in matches)
        {
            if (!dict.ContainsKey(match[0]))
            {
                dict[match[0]] = 0;
            }
            
            if (!dict.ContainsKey(match[1]))
            {
                dict[match[1]] = 0;
            }
            dict[match[1]]++;
        }
        
        foreach (var kv in dict)
        {
            if (kv.Value == 0)
            {
                result[0].Add(kv.Key);
            }
            else if (kv.Value == 1)
            {
                result[1].Add(kv.Key);
            }
        }
        
        return result;
    }
}
// @lc code=end

