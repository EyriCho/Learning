/*
 * @lc app=leetcode id=3306 lang=csharp
 *
 * [3306] Count of Substrings Containing Every Vowel and K Consonants II
 */

// @lc code=start
public class Solution {
    public long CountOfSubstrings(string word, int k) {
        int GetIndex(char c) => c switch
        {
            'a' => 0,
            'e' => 1,
            'i' => 2,
            'o' => 3,
            'u' => 4,
            _ => 5,
        };
        int[] chars = new int[6];

        long AtLeastK(int consonants)
        {
            int l = 0, r = 0,
                index = 0,
                vowels = 5;
            long rst = 0;
            Array.Fill(chars, 0);
            
            while (r < word.Length)
            {
                index = GetIndex(word[r]);
                chars[index]++;
                if (index < 5 && chars[index] == 1)
                {
                    vowels--;
                }

                while (chars[5] >= consonants &&
                    vowels == 0)
                {
                    rst += word.Length - r;
                    index = GetIndex(word[l++]);
                    chars[index]--;
                    if (index < 5 && chars[index] == 0)
                    {
                        vowels++;
                    }
                }
                r++;
            }
            return rst;
        }

        return AtLeastK(k) - AtLeastK(k + 1);
    }
}
// @lc code=end

