/*
 * @lc app=leetcode id=575 lang=csharp
 *
 * [575] Distribute Candies
 */

// @lc code=start
public class Solution {
    public int DistributeCandies(int[] candyType) {
        var set = new HashSet<int>();
        
        foreach (var type in candyType)
            if (!set.Contains(type))
                set.Add(type);
        
        return Math.Min(candyType.Length / 2, set.Count);
    }
}
// @lc code=end

