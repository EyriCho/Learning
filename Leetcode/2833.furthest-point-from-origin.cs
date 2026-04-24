/*
 * @lc app=leetcode id=2833 lang=csharp
 *
 * [2833] Furthest Point From Origin
 */

// @lc code=start
public class Solution {
    public int FurthestDistanceFromOrigin(string moves) {
        int left = 0,
            right = 0;
        
        foreach (char m in moves)
        {
            switch(m) {
                case 'R':
                    right++;
                    break;
                case 'L':
                    left++;
                    break;
                default:
                    break;
            };
        }

        return Math.Max(moves.Length - 2 * right,
            moves.Length - 2 * left);
    }
}
// @lc code=end

