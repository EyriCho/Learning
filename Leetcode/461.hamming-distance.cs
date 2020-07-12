/*
 * @lc app=leetcode id=461 lang=csharp
 *
 * [461] Hamming Distance
 */

// @lc code=start
public class Solution {
    public int HammingDistance(int x, int y) {
        int diff = x ^ y;
        int count = 0;
        while (diff != 0)
        {
            diff = diff & (diff - 1);
            count++;
        }
        return count;
    }
}
// @lc code=end

