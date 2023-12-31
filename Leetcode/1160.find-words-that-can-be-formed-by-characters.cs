/*
 * @lc app=leetcode id=1160 lang=csharp
 *
 * [1160] Find Words That Can Be Formed by Characters
 */

// @lc code=start
public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int[] ToArray(string s)
        {
            int[] rst = new int[26];
            foreach (char c in s)
            {
                rst[c - 'a']++;
            }
            return rst;
        }

        int[] c = ToArray(chars);
        int result = 0;

        foreach (string word in words)
        {
            int[] w = ToArray(word);

            int i = 0;
            for (; i < 26; i++)
            {
                if (w[i] > c[i])
                {
                    break;
                }
            }

            if (i == 26)
            {
                result += word.Length;
            }
        }

        return result;
    }
}
// @lc code=end

