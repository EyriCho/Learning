/*
 * @lc app=leetcode id=2182 lang=csharp
 *
 * [2182] Construct String With Repeat Limit
 */

// @lc code=start
public class Solution {
    public string RepeatLimitedString(string s, int repeatLimit) {
        int[] counts = new int[26];
        foreach (char c in s)
        {
            counts[c - 'a']++;
        }

        char[] array = new char[s.Length];
        int length = 0,
            fill = 0,
            current = 25,
            extra = 0;
        char ch;
        while (current >= 0)
        {
            if (counts[current] == 0)
            {
                current--;
                continue;
            }

            fill = Math.Min(counts[current], repeatLimit);
            counts[current] -= fill;
            ch = (char)('a' + current);
            while (fill-- > 0)
            {
                array[length++] = ch;
            }

            if (counts[current] == 0)
            {
                continue;
            }

            extra = current - 1;
            while (extra >= 0 && counts[extra] == 0)
            {
                extra--;
            }

            if (extra < 0)
            {
                break;
            }

            ch = (char)('a' + extra);
            counts[extra]--;
            array[length++] = ch;
        }
        
        return new string(array, 0, length);
    }
}
// @lc code=end

