/*
 * @lc app=leetcode id=1338 lang=csharp
 *
 * [1338] Reduce Array Size to The Half
 */

// @lc code=start
public class Solution {
    public int MinSetSize(int[] arr) {
        var dict = new Dictionary<int, int>();
        foreach (var num in arr)
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict[num] = 1;
        
        int result = 0, target = (arr.Length + 1) / 2,
            bucket = 0;
        foreach (var f in dict.Values)
            bucket = Math.Max(bucket, f);
        
        var buckets = new int[bucket + 1];
        foreach (var f in dict.Values)
            buckets[f]++;
        
        while (target > 0)
        {
            int maxNeeded = target / bucket;
            if (target % bucket != 0)
                maxNeeded++;
            
            maxNeeded = Math.Min(buckets[bucket], maxNeeded);
            result += maxNeeded;
            target -= bucket * maxNeeded;
            bucket--;
        }
        
        return result;
    }
}
// @lc code=end

