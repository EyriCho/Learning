/*
 * @lc app=leetcode id=2131 lang=csharp
 *
 * [2131] Longest Palindrome by Concatenating Two Letter Words
 */

// @lc code=start
public class Solution {
    public int LongestPalindrome(string[] words) {
        var w = 0;
        var counts = new int[26, 26];
        
        foreach (var word in words)
        {
            counts[word[0] - 'a', word[1] - 'a']++;
        }
        
        var pair = false;
        for (int i = 0; i < 26; i++)
        {
            if (counts[i, i] % 2 == 0)
            {
                w += counts[i, i];
            }
            else
            {
                w += counts[i, i] - 1;
                pair = true;
            }
            
            for (int j = i + 1; j < 26; j++)
            {
                w += 2 * Math.Min(counts[i, j], counts[j, i]);
            }
        }
        
        if (pair)
        {
            w++;
        }
        
        return w * 2;
    }
}
// @lc code=end

