/*
 * @lc app=leetcode id=1347 lang=csharp
 *
 * [1347] Minimum Number of Steps to Make Two Strings Anagram
 */

// @lc code=start
public class Solution {
    public int MinSteps(string s, string t) {
        int[] sCount = new int[26],
            tCount = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            sCount[s[i] - 'a']++;
            tCount[t[i] - 'a']++;
        }

        int result = 0;
        for (int i = 0 ; i < 26; i++)
        {
            int diff = sCount[i] - tCount[i];
            if (diff > 0)
            {
                result += diff;
            }
        }

        return result;
    }
}
// @lc code=end

