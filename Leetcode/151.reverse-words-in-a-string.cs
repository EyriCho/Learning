/*
 * @lc app=leetcode id=151 lang=csharp
 *
 * [151] Reverse Words in a String
 */

// @lc code=start
public class Solution {
    public string ReverseWords(string s) {
        var charArray = s.ToCharArray();
        var result = new char[s.Length];
        var index = 0;
        var wordEnd = s.Length - 1;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (charArray[i] == ' ')
            {
                if (wordEnd != i)
                {
                    if (index > 0)
                        result[index++] = '\u0020';
                    Array.Copy(charArray, i + 1, result, index, wordEnd - i);
                    index += wordEnd - i;
                }
                
                wordEnd = i - 1;
            }
            else if (i == 0)
            {
                if (index > 0)
                    result[index++] = '\u0020';
                Array.Copy(charArray, 0, result, index, wordEnd + 1);
                index += wordEnd + 1;
            }
        }
        return new string(result, 0, index);
    }
}
// @lc code=end

