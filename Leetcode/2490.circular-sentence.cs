/*
 * @lc app=leetcode id=2490 lang=csharp
 *
 * [2490] Circular Sentence
 */

// @lc code=start
public class Solution {
    public bool IsCircularSentence(string sentence) {
        if (sentence[0] != sentence[sentence.Length - 1])
        {
            return false;
        }

        char last = sentence[0];
        int i = 0;
        while (i < sentence.Length)
        {
            if (sentence[i] != last)
            {
                return false;
            }

            while (i < sentence.Length &&
                sentence[i] != ' ')
            {
                i++;
            }

            last = sentence[i - 1];
            i++;
        }

        return true;
    }
}
// @lc code=end

