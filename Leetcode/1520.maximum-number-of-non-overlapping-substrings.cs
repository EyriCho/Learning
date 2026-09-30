/*
 * @lc app=leetcode id=1520 lang=csharp
 *
 * [1520] Maximum Number of Non-Overlapping Substrings
 */

// @lc code=start
public class Solution {
    public IList<string> MaxNumOfSubstrings(string s) {
        int[] counts = new int[26],
            firsts = new int[26],
            lasts = new int[26];
        Array.Fill(firsts, -1);
        Array.Fill(lasts, -1);
        int idx = 0,
            total = 0,
            l = 0, r = 0,
            max = 0;
        for (int i = 0; i < s.Length; i++)
        {
            idx = s[i] - 'a';
            counts[idx]++;
            if (firsts[idx] == -1)
            {
                firsts[idx] = i;
            }
        }

        List<(int l, int r, int len)> list = new ();
        bool[] seems = new bool[26];
        for (int i = 0; i < 26; i++)
        {
            Array.Fill(seems, false);
            if (firsts[i] == -1)
            {
                continue;
            }
            l = r = firsts[i];
            total = 0;
            while (r < s.Length)
            {
                idx = s[r] - 'a';
                if (!seems[idx])
                {
                    total += counts[idx];
                    seems[idx] = true;
                }

                if (r - l + 1 == total)
                {
                    break;
                }
                r++;
            }

            if (r < s.Length)
            {
                list.Add((l, r, r - l + 1));
            }
        }

        list.Sort((a, b) => a.r.CompareTo(b.r));

        List<string> result = new ();
        int last = -1;

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].l > last)
            {
                result.Add(s[list[i].l..(list[i].r + 1)]);
                last = list[i].r;
            }
        }

        return result;
    }
}
// @lc code=end

