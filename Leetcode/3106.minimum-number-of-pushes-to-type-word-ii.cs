/*
 * @lc app=leetcode id=3106 lang=csharp
 *
 * [3106] Minimum Number of Pushes to Type Word II
 */

// @lc code=start
public class Solution {
    public int MinimumPushes(string word) {
        int[] counts = new int[26];
        foreach (char c in word)
        {
            counts[c - 'a']++;
        }
        Array.Sort(counts);

        int result = 0;
        for (int i = 25; i >= 0; i--)
        {
            result += (33 - i) / 8 * counts[i];
        }

        return result;
    }
}
// @lc code=end

