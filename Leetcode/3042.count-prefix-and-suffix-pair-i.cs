/*
 * @lc app=leetcode id=3042 lang=csharp
 *
 * [3042] Count Prefix and Suffix Pairs I
 */

// @lc code=start
public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int result = 0;
        
        bool isPrefixAndSuffix(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return false;
            }

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i] ||
                    str1[i] != str2[str2.Length - str1.Length + i])
                {
                    return false;
                }
            }

            return true;
        }

        for (int j = 1; j < words.Length; j++)
        {
            for (int i = 0; i < j; i++)
            {
                if (isPrefixAndSuffix(words[i], words[j]))
                {
                    result++;
                }
            }
        }

        return result;
    }
}
// @lc code=end

