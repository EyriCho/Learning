/*
 * @lc app=leetcode id=2014 lang=csharp
 *
 * [2014] Longest Subsequence Repeated k Times
 */

// @lc code=start
public class Solution {
    public string LongestSubsequenceRepeatedK(string s, int k) {
        int[] counts = new int[26];
        foreach (char c in s)
        {
            counts[c - 'a']++;
        }
        int length = 0;
        for (int i = 0; i < counts.Length; i++)
        {
            length += counts[i] / k;
        }
        if (length == 0)
        {
            return string.Empty;
        }

        bool IsSatisfy(string sub)
        {
            int sIndex = 0, total = sub.Length * k;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == sub[sIndex])
                {
                    total--;
                    sIndex = (sIndex + 1) % sub.Length;
                }
            }

            return total <= 0;
        }

        List<string> list = new ();
        char[] array = new char[length];
        void Dfs(int index)
        {
            if (index == length)
            {
                list.Add(new string(array, 0, length));
            }

            for (int c = 25; c >= 0; c--)
            {
                if (counts[c] >= k)
                {
                    array[index] = (char)(c + 'a');
                    counts[c] -= k;
                    Dfs(index + 1);
                    counts[c] += k;
                }
            }
        }

        while (length > 0)
        {
            list.Clear();
            
            Dfs(0);
            foreach (string sub in list)
            {
                if (IsSatisfy(sub))
                {
                    return sub;
                }
            }

            length--;
        }

        return string.Empty;
    }
}
// @lc code=end

