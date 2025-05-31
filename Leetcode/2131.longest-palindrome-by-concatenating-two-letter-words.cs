/*
 * @lc app=leetcode id=2131 lang=csharp
 *
 * [2131] Longest Palindrome by Concatenating Two Letter Words
 */

// @lc code=start
public class Solution {
    public int LongestPalindrome(string[] words) {
        int[,] counts = new int[26, 26];
        foreach (string word in words)
        {
            counts[word[0] - 'a', word[1] - 'a']++;
        }

        bool pair = false;
        int total = 0;
        for (int i = 0; i < 26; i++)
        {
            if (counts[i, i] % 2 == 0)
            {
                total += counts[i, i];
            }
            else
            {
                total += counts[i, i] - 1;
                pair = true;
            }

            for (int j = i + 1; j < 26; j++)
            {
                total += Math.Min(counts[i, j], counts[j, i]) << 1;
            }
        }
        
        if (pair)
        {
            total++;
        }

        return total << 1;
    }
}
// @lc code=end

