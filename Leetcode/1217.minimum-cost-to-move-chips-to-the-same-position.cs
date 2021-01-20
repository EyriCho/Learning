/*
 * @lc app=leetcode id=1217 lang=csharp
 *
 * [1217] Minimum Cost to Move Chips to The Same Position
 */

// @lc code=start
public class Solution {
    public int MinCostToMoveChips(int[] position) {
        int odd = 0, even = 0;
        
        for (int i = 0; i < position.Length; i++)
        {
            if ((position[i] & 1) == 0)
                even++;
            else
                odd++;
        }
        
        return odd > even ? even : odd;
    }
}
// @lc code=end

