/*
 * @lc app=leetcode id=824 lang=csharp
 *
 * [824] Goat Latin
 */

// @lc code=start
public class Solution {
    public string ToGoatLatin(string S) {
        if (S.Length == 0) return string.Empty;
        
        var list = new List<char>(S.Length);
        int count = 1;
        char? firstChar = null;
        var vowel = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        if (vowel.Contains(S[0]))
        {
            list.Add(S[0]);
        }
        else
        {
            firstChar = S[0];
        }
        
        int i = 1;
        for (; i < S.Length; i++)
        {
            var c = S[i];
            if (c == ' ')
            {
                if (firstChar.HasValue)
                    list.Add(firstChar.Value);
                if (i != S.Length - 1)
                {
                    if (vowel.Contains(S[i + 1]))
                        firstChar = null;
                    else
                    {
                        firstChar = S[i + 1];
                        i++;
                    }
                }
                
                list.Add('m');
                list.Add('a');
                var _count = count++;
                while (_count > 0)
                {
                    list.Add('a');
                    _count--;
                }
                list.Add(' ');
            }
            else
            {
                list.Add(c);
            }
        }
        
        if (S[S.Length - 1] != ' ')
        {
            if (firstChar.HasValue)
                list.Add(firstChar.Value);
            
            list.Add('m');
            list.Add('a');
            while (count > 0)
            {
                list.Add('a');
                count--;
            }
        }
        
        return new string(list.ToArray());
    }
}
// @lc code=end

