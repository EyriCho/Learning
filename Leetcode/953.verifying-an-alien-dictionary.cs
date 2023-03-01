/*
 * @lc app=leetcode id=953 lang=csharp
 *
 * [953] Verifying an Alien Dictionary
 */

// @lc code=start
public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < 26; i++)
        {
            dict[order[i]] = i;
        }

        bool Compare(string l, string r)
        {
            var length = Math.Min(l.Length, r.Length);

            for (int i = 0; i < length; i++)
            {
                if (dict[l[i]] < dict[r[i]])
                {
                    return true;
                }
                else if (dict[l[i]] > dict[r[i]])
                {
                    return false;
                }
            }

            return r.Length >= l.Length;
        }

        for (int i = 1; i < words.Length; i++)
        {
            if (!Compare(words[i - 1], words[i]))
            {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

