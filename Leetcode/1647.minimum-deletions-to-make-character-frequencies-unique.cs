/*
 * @lc app=leetcode id=1647 lang=csharp
 *
 * [1647] Minimum Deletions to Make Character Frequencies Unique
 */

// @lc code=start
public class Solution {
    public int MinDeletions(string s) {
        var freq = new int[26];
        
        foreach (var c in s)
        {
            freq[c - 'a']++;
        }
        
        var result = 0;
        var set = new HashSet<int>();
        for (int i = 0; i < 26; i++)
        {
            while (freq[i] > 0 && set.Contains(freq[i]))
            {
                freq[i]--;
                result++;
            }
            set.Add(freq[i]);
        }
        
        return result;
    }
}
// @lc code=end

