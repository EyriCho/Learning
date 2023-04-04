/*
 * @lc app=leetcode id=443 lang=csharp
 *
 * [443] String Compression
 */

// @lc code=start
public class Solution {
    public int Compress(char[] chars) {
        int i = 0, j = 0;

        while (i < chars.Length)
        {
            int l = i++;
            while (i < chars.Length && chars[i] == chars[l])
            {
                i++;
            }
            var count = i - l;

            if (count == 1)
            {
                chars[j++] = chars[l];
            }
            else
            {
                chars[j++] = chars[l];
                foreach (var c in count.ToString())
                {
                    chars[j++] = c;
                }
            }
        }

        return j;
    }
}
// @lc code=end

