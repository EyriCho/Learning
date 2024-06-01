/*
 * @lc app=leetcode id=205 lang=csharp
 *
 * [205] Isomorphic Strings
 */

// @lc code=start
public class Solution {
    public bool IsIsomorphic(string s, string t) {
        int[] map = new int[256];

        for (int i = 0; i < t.Length; i++)
        {
            int index = t[i] + 128;
            if (map[s[i]] != map[index])
            {
                return false;
            }

            map[s[i]] = map[index] = i + 1;
        }
        
        return true;
    }
}
// @lc code=end

