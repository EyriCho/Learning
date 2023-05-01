/*
 * @lc app=leetcode id=1768 lang=csharp
 *
 * [1768] Merge Strings Alternately
 */

// @lc code=start
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var array = new char[word1.Length + word2.Length];

        int i1 = 0, i2 = 0, j = 0;

        while (i1 < word1.Length && i2 < word2.Length)
        {
            array[j++] = word1[i1++];
            array[j++] = word2[i2++];
        }

        while (i1 < word1.Length)
        {
            array[j++] = word1[i1++];
        }

        while (i2 < word2.Length)
        {
            array[j++] = word2[i2++];
        }

        return new string(array);
    }
}
// @lc code=end

