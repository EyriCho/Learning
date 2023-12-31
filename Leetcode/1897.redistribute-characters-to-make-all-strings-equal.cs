/*
 * @lc app=leetcode id=1897 lang=csharp
 *
 * [1897] Redistribute Characters to Make All Strings Equal
 */

// @lc code=start
public class Solution {
    public bool MakeEqual(string[] words) {
        int[] chars = new int[26];
        foreach (string word in words)
        {
            foreach (char c in word)
            {
                chars[c - 'a']++;
            }
        }

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] % words.Length != 0)
            {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

