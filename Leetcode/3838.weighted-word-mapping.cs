/*
 * @lc app=leetcode id=3838 lang=csharp
 *
 * [3838] Weighted Word Mapping
 */

// @lc code=start
public class Solution {
    public string MapWordWeights(string[] words, int[] weights) {
        char[] array = new char[words.Length];

        int sum = 0;
        for (int i = 0; i < words.Length; i++)
        {
            sum = 0;
            foreach (char c in words[i])
            {
                sum += weights[c - 'a'];
            }

            array[i] = (char)('a' + 25 - (sum % 26));
        }

        return new string(array);
    }
}
// @lc code=end

