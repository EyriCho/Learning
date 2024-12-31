/*
 * @lc app=leetcode id=1455 lang=csharp
 *
 * [1455] Check If a Word Occurs As a Prefix of Any Word in a Sentence
 */

// @lc code=start
public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        int s = 0,
            w = 0,
            c = 1;

        while (s < sentence.Length)
        {
            w = 0;
            while (s < sentence.Length &&
                sentence[s] != ' ' &&
                w < searchWord.Length &&
                sentence[s] == searchWord[w])
            {
                s++;
                w++;
            }

            if (w == searchWord.Length)
            {
                return c;
            }

            while (s < sentence.Length &&
                sentence[s] != ' ')
            {
                s++;
            }

            s++;
            c++;
        }

        return -1;
    }
}
// @lc code=end

