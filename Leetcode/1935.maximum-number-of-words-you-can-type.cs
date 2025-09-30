/*
 * @lc app=leetcode id=1935 lang=csharp
 *
 * [1935] Maximum Number of Words You Can Type
 */

// @lc code=start
public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        int mask = 0;
        foreach (char c in brokenLetters)
        {
            mask |= 1 << (c - 'a');
        }
        
        bool broken = false;
        int result = 0;
        foreach (char c in text)
        {
            if (c == ' ')
            {
                if (!broken)
                {
                    result++;
                }
                broken = false;
                continue;
            }

            if (broken)
            {
                continue;
            }
            if ((mask & 1 << (c - 'a')) > 0)
            {
                broken = true;
            }
        }

        if (!broken)
        {
            result++;
        }

        return result;
    }
}
// @lc code=end

