/*
 * @lc app=leetcode id=134 lang=csharp
 *
 * [134] Gas Station
 */

// @lc code=start
public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int left = 0, min = int.MaxValue, index = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            left += gas[i] - cost[i];
            if (left < min)
            {
                min = left;
                index = (i + 1) % gas.Length;
            }
        }
        
        if (left < 0)
            return -1;
        
        return index;
    }
}
// @lc code=end

