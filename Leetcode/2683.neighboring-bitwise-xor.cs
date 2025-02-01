/*
 * @lc app=leetcode id=2683 lang=csharp
 *
 * [2683] Neighboring Bitwise XOR
 */

// @lc code=start
public class Solution {
    public bool DoesValidArrayExist(int[] derived) {
        int xor = 0;
        foreach (int d in derived)
        {
            xor ^= d;
        }
        return xor == 0;
    }
}
// @lc code=end

