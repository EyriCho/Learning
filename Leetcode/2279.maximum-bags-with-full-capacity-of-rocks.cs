/*
 * @lc app=leetcode id=2279 lang=csharp
 *
 * [2279] Maximum Bags With Full Capacity of Rocks
 */

// @lc code=start
public class Solution {
    public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks) {
        
        for (int i = 0; i < capacity.Length; i++)
        {

            capacity[i] -= rocks[i];
        }

        Array.Sort(capacity);

        int j = 0;
        while (j < capacity.Length && capacity[j] <= additionalRocks)
        {
            additionalRocks -= capacity[j++];
        }

        return j;
    }
}
// @lc code=end

