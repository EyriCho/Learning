/*
 * @lc app=leetcode id=567 lang=csharp
 *
 * [567] Permutation in String
 */

// @lc code=start
public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        Dictionary<char, int> dict = new ();
        int count = 0;
        foreach (char c in s1)
        {
            dict.TryGetValue(c, out count);
            dict[c] = count + 1;
        }

        int l = 0, r = 0;
        count = dict.Count;

        while (r < s2.Length)
        {
            if (dict.ContainsKey(s2[r]))
            {
                dict[s2[r]]--;
                if (dict[s2[r]] == 0)
                {
                    count--;
                }
            }

            r++;

            while (count == 0)
            {
                if (dict.ContainsKey(s2[l]))
                {
                    dict[s2[l]]++;
                    if (dict[s2[l]] > 0)
                    {
                        count++;
                    }
                }

                if (r - l == s1.Length)
                {
                    return true;
                }

                l++;
            }
        }

        return false;
    }
}
// @lc code=end

