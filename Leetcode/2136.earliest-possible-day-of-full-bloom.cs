/*
 * @lc app=leetcode id=2136 lang=csharp
 *
 * [2136] Earliest Possible Day of Full Bloom
 */

// @lc code=start
public class Solution {
    public int EarliestFullBloom(int[] plantTime, int[] growTime) {
        var plantGrow = new (int, int)[plantTime.Length];
        for (int i = 0; i < plantTime.Length; i++)
        {
            plantGrow[i] = (plantTime[i], growTime[i]);
        }
        
        Array.Sort(plantGrow, (a, b) =>
            a.Item2 == b.Item2 ? b.Item1 - a.Item1 : b.Item2 - a.Item2);
        
        int time = 0, result = 0;
        for (int i = 0; i < plantTime.Length; i++)
        {
            time += plantGrow[i].Item1;
            result = Math.Max(time + plantGrow[i].Item2, result);
        }
        
        return result;
    }
}
// @lc code=end

