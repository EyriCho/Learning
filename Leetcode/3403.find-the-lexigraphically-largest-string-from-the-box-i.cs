/*
 * @lc app=leetcode id=3403 lang=csharp
 *
 * [3403] Find the Lexicographically Largest String From the Box I
 */

// @lc code=start
public class Solution {
    public string AnswerString(string word, int numFriends) {
        if (numFriends == 1)
        {
            return word;
        }

        string result = string.Empty,
            sub = string.Empty;
        int maxLength = word.Length - numFriends + 1;
        
        for (int i = 0; i < word.Length; i++)
        {
            sub = word.Substring(i, Math.Min(word.Length - i, maxLength));
            if (sub.CompareTo(result) > 0)
            {
                result = sub;
            }
        }

        return result;
    }
}
// @lc code=end

