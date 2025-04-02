/*
 * @lc app=leetcode id=763 lang=csharp
 *
 * [763] Partition Labels
 */

// @lc code=start
public class Solution {
    public IList<int> PartitionLabels(string s) {
        int[] lasts = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            lasts[s[i] - 'a'] = i;
        }

        List<int> result = new ();
        int idx = 0,
            start = 0,
            last = 0;
        for (int i = 0; i < s.Length; i++)
        {
            idx = lasts[s[i] - 'a'];
            last = Math.Max(last, idx);

            if (i == last)
            {
                result.Add(last - start + 1);
                start = i + 1;
            }
        }
        return result;
    }
}
// @lc code=end

