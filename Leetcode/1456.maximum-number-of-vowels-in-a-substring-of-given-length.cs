/*
 * @lc app=leetcode id=1456 lang=csharp
 *
 * [1456] Maximum Number of Vowels in a Substring of Given Length
 */

// @lc code=start
public class Solution {
    public int MaxVowels(string s, int k) {
        var set = new HashSet<char>() {
            'a', 'e', 'i', 'o', 'u'
        };

        var count = 0;
        int i = 0;
        while (i < k && i < s.Length)
        {
            if (set.Contains(s[i]))
            {
                count++;
            }
            i++;
        }
        var max = count;
        while (i < s.Length)
        {
            if (set.Contains(s[i]))
            {
                count++;
            }
            if (set.Contains(s[i - k]))
            {
                count--;
            }

            max = Math.Max(max, count);
            i++;
        }
        return max;
    }
}
// @lc code=end

