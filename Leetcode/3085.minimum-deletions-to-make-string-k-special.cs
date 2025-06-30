/*
 * @lc app=leetcode id=3085 lang=csharp
 *
 * [3085] Minimum Deletions to Make String K-Special
 */

// @lc code=start
public class Solution {
    public int MinimumDeletions(string word, int k) {
        int[] freqs = new int[26];
        foreach (char c in word)
        {
            freqs[c - 'a']++;
        }

        Array.Sort(freqs);

        int result = word.Length,
            l = 0,
            curSum = 0,
            deletes = 0;
        while (l < freqs.Length && freqs[l] == 0)
        {
            l++;
        }
        for (int r = l; r < freqs.Length; r++)
        {
            while (freqs[r] - freqs[l] > k)
            {
                deletes = word.Length - curSum - (freqs[l] + k) * (freqs.Length - r);
                result = Math.Min(result, deletes);
                curSum -= freqs[l++];
            }

            curSum += freqs[r];
        }

        result = Math.Min(result, word.Length - curSum);

        return result;
    }
}
// @lc code=end

