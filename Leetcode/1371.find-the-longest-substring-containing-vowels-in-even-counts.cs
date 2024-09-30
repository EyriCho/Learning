/*
 * @lc app=leetcode id=1371 lang=csharp
 *
 * [1371] Find the Longest Substring Containing Vowels in Even Counts
 */

// @lc code=start
public class Solution {
    public int FindTheLongestSubstring(string s) {
        Dictionary<char, int> dict = new () {
            { 'a', 0 },
            { 'e', 1 },
            { 'i', 2 },
            { 'o', 3 },
            { 'u', 4 },
        };

        Dictionary<int, int> prev = new ();
        prev[0] = -1;
        int prefix = 0,
            result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                prefix ^= 1 << dict[s[i]];
            }

            if (prev.ContainsKey(prefix))
            {
                result = Math.Max(result, i - prev[prefix]);
            }
            else
            {
                prev[prefix] = i;
            }
        }

        return result;
    }
}
// @lc code=end

