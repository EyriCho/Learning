/*
 * @lc app=leetcode id=151 lang=csharp
 *
 * [151] Reverse Words in a String
 */

// @lc code=start
public class Solution {
    public string ReverseWords(string s) {
        var array = new char[s.Length];
        
        int i = s.Length - 1, j = 0;
        while (i > -1)
        {
            int last = i + 1;
            while (i > -1 && s[i] != ' ')
                i--;
            
            int k = 1 + i--;
            if (k < last)
            {
                if (j > 0)
                    array[j++] = ' ';
                while (k < last)
                    array[j++] = s[k++];
            }
        }
        
        return new string(array, 0, j);
    }
}
// @lc code=end

