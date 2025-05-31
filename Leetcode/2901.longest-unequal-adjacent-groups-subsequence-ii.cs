/*
 * @lc app=leetcode id=2901 lang=csharp
 *
 * [2901] Longest Unequal Adjacent Groups Subsequence II
 */

// @lc code=start
public class Solution {
    public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups) {
        (int, int)[] sequence = new (int, int)[words.Length];
        sequence[0] = (-1, 1);

        int max = 1,
            maxIdx = 0,
            diff = 0;
        for (int i = 1; i < words.Length; i++)
        {
            sequence[i] = (-1, 1);
            
            for (int prev = i - 1; prev >= 0; prev--)
            {
                if (groups[i] == groups[prev] ||
                    words[i].Length != words[prev].Length)
                {
                    continue;
                }

                diff = 0;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (words[i][j] != words[prev][j])
                    {
                        diff++;
                    }
                }

                if (diff != 1 || sequence[prev].Item2 < sequence[i].Item2)
                {
                    continue;
                }

                sequence[i] = (prev, sequence[prev].Item2 + 1);
            }

            if (sequence[i].Item2 > max)
            {
                max = sequence[i].Item2;
                maxIdx = i;
            }
        }

        List<string> result = new ();
        while (maxIdx > -1)
        {
            result.Add(words[maxIdx]);
            maxIdx = sequence[maxIdx].Item1;
        }
        result.Reverse();
        return result;
    }
}
// @lc code=end

