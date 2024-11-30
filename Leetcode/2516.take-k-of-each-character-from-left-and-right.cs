/*
 * @lc app=leetcode id=2516 lang=csharp
 *
 * [2516] Take K of Each Character From Left and Right
 */

// @lc code=start
public class Solution {
    public int TakeCharacters(string s, int k) {
        int[] counts = new int[3],
            windows = new int[3];
        foreach (char c in s)
        {
            counts[c - 'a']++;
        }

        if (counts[0] < k ||
            counts[1] < k ||
            counts[2] < k)
        {
            return -1;
        }

        int l = 0,
            r = 0,
            max = 0;

        while (r < s.Length)
        {
            windows[s[r] - 'a']++;

            while (l <= r &&
                (counts[0] - windows[0] < k ||
                counts[1] - windows[1] < k ||
                counts[2] - windows[2] < k))
            {
                windows[s[l++] - 'a']--;
            }

            max = Math.Max(max, r - l + 1);
            r++;
        }

        return s.Length - max;
    }
}
// @lc code=end

