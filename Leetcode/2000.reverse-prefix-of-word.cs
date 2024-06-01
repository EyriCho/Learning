/*
 * @lc app=leetcode id=2000 lang=csharp
 *
 * [2000] Reverse Prefix of Word
 */

// @lc code=start
public class Solution {
    public string ReversePrefix(string word, char ch) {
        char[] array = word.ToCharArray();
        char temp = 'a';

        int l = 0,
            r = 0;
        
        while (r < word.Length && word[r] != ch)
        {
            r++;
        }

        if (r == word.Length)
        {
            return word;
        }

        while (l < r)
        {
            temp = array[l];
            array[l++] = array[r];
            array[r--] = temp;
        }

        return new string(array);
    }
}
// @lc code=end

