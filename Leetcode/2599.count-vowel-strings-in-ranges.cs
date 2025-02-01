/*
 * @lc app=leetcode id=2599 lang=csharp
 *
 * [2559] Count Vowel Strings in Ranges
 */

// @lc code=start
public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        int[] counts = new int[words.Length + 1];
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        for (int i = 0; i < words.Length; i++)
        {
            counts[i + 1] += counts[i];
            if (vowels.Contains(words[i][0]) &&
                vowels.Contains(words[i][words[i].Length - 1]))
            {
                counts[i + 1]++;
            }
        }

        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            result[i] = counts[queries[i][1] + 1] - counts[queries[i][0]];
        }
        return result;
    }
}
// @lc code=end

