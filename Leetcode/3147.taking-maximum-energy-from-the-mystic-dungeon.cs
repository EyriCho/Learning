/*
 * @lc app=leetcode id=3147 lang=csharp
 *
 * [3147] Taking Maximum Energy From the Mystic Dungeon
 */

// @lc code=start
public class Solution {
    public int MaximumEnergy(int[] energy, int k) {
        int result = int.MinValue,
            prev = 0;

        for (int i = energy.Length - 1; i >= 0; i--)
        {
            result = Math.Max(result, energy[i]);
            prev = i - k;
            if (prev >= 0)
            {
                energy[prev] += energy[i];
            }
        }
        
        return result;
    }
}
// @lc code=end

