/*
 * @lc app=leetcode id=3136 lang=csharp
 *
 * [3136] Valid Word
 */

// @lc code=start
public class Solution {
    public bool IsValid(string word) {
        if (word.Length < 3)
        {
            return false;
        }

        char[] vowels = { 'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U' };

        bool vowel = false,
            consonant = false;
        
        foreach (char c in word)
        {
            if (Char.IsDigit(c))
            {
                continue;
            }
            else if (Char.IsAsciiLetter(c))
            {
                if (vowels.Contains(c))
                {
                    vowel = true;
                }
                else
                {
                    consonant = true;
                }
            }
            else
            {
                return false;
            }
        }

        return vowel && consonant;
    }
}
// @lc code=end

