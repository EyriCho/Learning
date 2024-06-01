/*
 * @lc app=leetcode id=1915 lang=csharp
 *
 * [1915] Number of Wonderful Substrings
 */

// @lc code=start
public class Solution {
    public long WonderfulSubstrings(string word) {
        Dictionary<int, long> dict = new();
        dict[0] = 1L;
        long result = 0;
        int flag = 0;

        for (int i = 0; i < word.Length; i++)
        {
            flag ^= 1 << (word[i] - 'a');
            dict.TryGetValue(flag, out long c);
            result += c;

            for (int j = 0; j < 10; j++)
            {
                dict.TryGetValue(flag ^ (1 << j), out long cOdd);
                result += cOdd;
            }

            dict[flag] = c + 1;
        }

        return result;
    }
}
// @lc code=end

