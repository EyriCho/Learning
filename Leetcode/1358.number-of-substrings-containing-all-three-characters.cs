/*
 * @lc app=leetcode id=1358 lang=csharp
 *
 * [1358] Number of Substrings Containing All Three Characters
 */

// @lc code=start
public class Solution {
    public int NumberOfSubstrings(string s) {
        int[] counts = new int[3];
        int result = 0,
            three = 3,
            abc = 0;
        for (int l = 0, r = 0; r < s.Length; r++)
        {
            abc = s[r] - 'a';
            counts[abc]++;
            if (counts[abc] == 1)
            {
                three--;
            }

            while (three == 0)
            {
                result += s.Length - r;

                abc = s[l++] - 'a';
                counts[abc]--;
                if (counts[abc] == 0)
                {
                    three++;
                }
            }
        }

        return result;
    }
}
// @lc code=end

