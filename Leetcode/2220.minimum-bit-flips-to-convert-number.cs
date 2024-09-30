/*
 * @lc app=leetcode id=2220 lang=csharp
 *
 * [2220] Minimum Bit Flips to Convert Number
 */

// @lc code=start
public class Solution {
    public int MinBitFlips(int start, int goal) {
        int move = start ^ goal,
            result = 0;
        while (move > 0)
        {
            result++;
            move &= move - 1;
        }

        return result;
    }
}
// @lc code=end

