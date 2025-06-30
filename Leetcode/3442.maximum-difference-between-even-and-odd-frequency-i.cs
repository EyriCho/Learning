/*
 * @lc app=leetcode id=3442 lang=csharp
 *
 * [3442] Maximum Difference Between Even and Odd Frequency I
 */

// @lc code=start
public class Solution {
    public int MaxDifference(string s) {
        int[] odds = new int[26],
            counts = new int[26];

        int esult = int.MinValue,
            max = 0,
            min = s.Length;

        for (int i = 0; i < s.Length; i++)
        {
            counts[s[i] - 'a']++;
        }

        for (int i = 0; i < 26; i++)
        {
            if ((counts[i] & 1) == 1)
            {
                max = Math.Max(max, counts[i]);

            }
            else if (counts[i] > 0)
            {
                min = Math.Min(min, counts[i]);
            }
        }
        
        return max - min;
    }
}
// @lc code=end

