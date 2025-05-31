/*
 * @lc app=leetcode id=2900 lang=csharp
 *
 * [2900] Longest Unequal Adjacent Groups Subsequence I
 */

// @lc code=start
public class Solution {
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        List<string> result = new ();
        result.Add(words[0]);
        int i = 1,
            last = 0;
        while (i < words.Length)
        {
            while (i < words.Length && groups[last] == groups[i])
            {
                i++;
            }

            if (i < words.Length)
            {
                result.Add(words[i]);
                last = i++;
            }
        }

        return result;
    }
}
// @lc code=end

