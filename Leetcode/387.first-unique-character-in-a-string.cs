/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 */

// @lc code=start
public class Solution {
    public int FirstUniqChar(string s) {
        int[] characters = new int[26];
        Array.Fill(characters, -1);

        for (int i = 0; i < s.Length; i++)
        {
            int c = s[i] - 'a';
            characters[c] = characters[c] > -1 ?
                int.MaxValue : i;
        }

        int result = int.MaxValue;
        foreach (int p in characters)
        {
            if (p > -1)
            {
                result = Math.Min(result, p);
            }
        }

        return result == int.MaxValue ? -1 : result;
    }
}
// @lc code=end

