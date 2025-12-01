/*
 * @lc app=leetcode id=2154 lang=csharp
 *
 * [2154] Keep Multiplying Found Values by Two
 */

// @lc code=start
public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        HashSet<int> set = new (nums);
        
        while (set.Contains(original))
        {
            original <<= 1;
        }

        return original;
    }
}
// @lc code=end

