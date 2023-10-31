/*
 * @lc app=leetcode id=2433 lang=csharp
 *
 * [2433] Find The Original Array of Prefix Xor
 */

// @lc code=start
public class Solution {
    public int[] FindArray(int[] pref) {
        int[] result = new int[pref.Length];
        result[0] = pref[0];
        for (int i = 1; i < pref.Length; i++)
        {
            result[i] = pref[i - 1] ^ pref[i];
        }
        return result;
    }
}
// @lc code=end

