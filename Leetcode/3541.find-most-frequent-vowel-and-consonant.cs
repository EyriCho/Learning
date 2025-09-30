/*
 * @lc app=leetcode id=3541 lang=csharp
 *
 * [3541] Find Most Frequent Vowel and Consonant
 */

// @lc code=start
public class Solution {
    public int MaxFreqSum(string s) {
        int[] freqs = new int[26];
        foreach (char c in s)
        {
            freqs[c - 'a']++;
        }

        int maxVowels = 0,
            maxConsonant = 0;
        
        for (int i = 0; i < 26; i++)
        {
            switch (i)
            {
                case 0:
                case 4:
                case 8:
                case 14:
                case 20:
                    maxVowels = Math.Max(maxVowels, freqs[i]);
                    break;
                default:
                    maxConsonant = Math.Max(maxConsonant, freqs[i]);
                    break;
            }
        }

        return maxVowels + maxConsonant;
    }
}
// @lc code=end

