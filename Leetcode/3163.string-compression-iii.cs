/*
 * @lc app=leetcode id=3163 lang=csharp
 *
 * [3163] String Compression III
 */

// @lc code=start
public class Solution {
    public string CompressedString(string word) {
        List<char> list = new ();
        int i = 0,
            r = 0,
            count = 0;

        while (i < word.Length)
        {
            r = i;
            while (r < word.Length &&
                word[i] == word[r])
            {
                r++;
            }

            count = r - i;
            while (count > 9)
            {
                list.Add('9');
                list.Add(word[i]);
                count -= 9;
            }

            if (count > 0)
            {
                list.Add((char)('0' + count));
                list.Add(word[i]);
            }

            i = r;
        }

        return new string(list.ToArray());
    }
}
// @lc code=end

