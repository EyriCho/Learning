/*
 * @lc app=leetcode id=3734 lang=csharp
 *
 * [3734] Lexicographically Smallest Palindromic Permutation Greater Than Target
 */

// @lc code=start
public class Solution {
    public string LexPalindromicPermutation(string s, string target) {
        int[] counts = new int[26];
        foreach (char c in s)
        {
            counts[c - 'a']++;
        }
        
        int odds = 0;
        char single = 'a';
        for (int i = 0; i < 26; i++)
        {
            if (counts[i] % 2 == 1)
            {
                if (odds == 1)
                {
                    return string.Empty;
                }
                odds = 1;
                single = (char)('a' + i);
            }
        }

        int half = s.Length >> 1;
        char[] array = new char[s.Length];
        bool Construct(int idx)
        {
            if (idx == half)
            {
                if (s.Length % 2 == 0)
                {
                    return string.Compare(new string(array), target) > 0;
                }
                else
                {
                    if (single < target[idx])
                    {
                        return false;
                    }

                    array[idx] = single;
                    return string.Compare(new string(array), target) > 0;
                }
            }

            int i = target[idx] - 'a';
            if (counts[i] > 1)
            {
                counts[i] -= 2;
                array[idx] = array[array.Length - 1 - idx] = (char)('a' + i);
                if (Construct(idx + 1))
                {
                    return true;
                }
                counts[i] += 2;
            }

            for (i++; i < 26; i++)
            {
                if (counts[i] < 2)
                {
                    continue;
                }

                counts[i] -= 2;
                array[idx] = array[array.Length - 1 - idx] = (char)('a' + i);
                idx++;

                for (int j = 0; j < 26; j++)
                {
                    while (counts[j] > 1)
                    {
                        counts[j] -= 2;
                        array[idx] = array[array.Length - 1 - idx] = (char)('a' + j);
                        idx++;
                    }
                }

                if (array.Length % 2 == 1)
                {
                    array[idx] = single;
                }

                return true;
            }

            return false;
        }

        if (Construct(0))
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

