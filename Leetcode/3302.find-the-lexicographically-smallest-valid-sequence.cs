/*
 * @lc app=leetcode id=3302 lang=csharp
 *
 * [3302] Find the Lexicographically Smallest Valid Sequence
 */

// @lc code=start
public class Solution {
    public int[] ValidSequence(string word1, string word2) {
        int[] last = new int[word2.Length];
        Array.Fill(last, -1);
        int i1 = word1.Length - 1,
            i2 = word2.Length - 1,
            skip = 0;
        for (; i1 >= 0; i1--)
        {
            if (i2 >= 0 &&
                word1[i1] == word2[i2])
            {
                last[i2--] = i1;
            }
        }

        int[] result = new int[word2.Length];
        i2 = 0;
        for (i1 = 0; i1 < word1.Length; i1++)
        {
            if (i2 == word2.Length)
            {
                break;
            }

            if (word1[i1] == word2[i2] ||
                (skip == 0 && (i2 == word2.Length - 1 || i1 < last[i2 + 1])))
            {
                skip += word1[i1] == word2[i2] ? 0 : 1;
                result[i2++] = i1;
            }
        }

        return i2 == word2.Length ? result : new int[0];
    }
}
// @lc code=end

