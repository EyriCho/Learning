/*
 * @lc app=leetcode id=1528 lang=csharp
 *
 * [1528] Shuffle String
 */

// @lc code=start
public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] a = new char[indices.Length];
        for (int i = 0; i < indices.Length; i++)
        {
            a[indices[i]] = s[i];
        }
        return new string(a);
    }
}
// @lc code=end

