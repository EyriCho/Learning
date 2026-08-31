/*
 * @lc app=leetcode id=3720 lang=csharp
 *
 * [3720] Lexicographically Smallest Permutation Greater Than Target
 */

// @lc code=start
public class Solution {
    public string LexGreaterPermutation(string s, string target) {
        int[] counts = new int[26];
        foreach (char c in s)
        {
            counts[c - 'a']++;
        }
        char[] array = new char[s.Length];

        bool Check(int idx)
        {
            if (idx == array.Length)
            {
                return false;
            }

            int i = target[idx] - 'a';
            if (counts[i] > 0)
            {
                counts[i]--;
                array[idx] = (char)(i + 'a');
                if (Check(idx + 1))
                {
                    return true;
                }
                counts[i]++;
            }

            for (i++; i < 26; i++)
            {
                if (counts[i] == 0)
                {
                    continue;
                }

                counts[i]--;
                array[idx++] = (char)(i + 'a');

                for (int j = 0; j < 26; j++)
                {
                    while (counts[j]-- > 0)
                    {
                        array[idx++] = (char)(j + 'a');
                    }
                }

                return true;
            }

            return false;
        }

        if (Check(0))
        {
            return new string(array);
        }
        else
        {
            return string.Empty;
        }
    }
}
// @lc code=end

