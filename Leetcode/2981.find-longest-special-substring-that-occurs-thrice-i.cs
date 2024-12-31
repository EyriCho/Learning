/*
 * @lc app=leetcode id=2981 lang=csharp
 *
 * [2981] Find Longest Special Substring That Occurs Thrice I
 */

// @lc code=start
public class Solution {
    public int MaximumLength(string s) {
        Dictionary<string, int> dict = new ();

        int i = 0,
            l = 0,
            c = 0,
            maxStream = 0,
            count = 0,
            result = -1;
        while (i < s.Length)
        {
            l = i++;

            while (i < s.Length &&
                s[i] == s[l])
            {
                i++;
            }

            c = i - l;
            if (c > 2)
            {
                result = Math.Max(result, c - 2);
            }

            if (c > 1)
            {
                dict.TryGetValue(s[(l + 1)..i], out count);
                count += 2;
                dict[s[(l + 1)..i]] = count;
                if (count > 2)
                {
                    result = Math.Max(result, c - 1);
                }
            }

            dict.TryGetValue(s[l..i], out count);
            count++;
            dict[s[l..i]] = count;
            if (count > 2)
            {
                result = Math.Max(result, c);
            }
        }

        return result;
    }
}
// @lc code=end

