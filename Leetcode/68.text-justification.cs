/*
 * @lc app=leetcode id=68 lang=csharp
 *
 * [68] Text Justification
 */

// @lc code=start
public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        var result = new List<string>();
        int i = 0;
        while (i < words.Length)
        {
            var len = words[i].Length;
            var r = i + 1;
            while (r < words.Length && len + words[r].Length + 1 <= maxWidth)
            {
                len += words[r++].Length + 1;
            }

            var array = new char[maxWidth];
            int idx = 0;

            if (r == words.Length || r - i == 1)
            {
                int j = i;
                for (; j < r; j++)
                {
                    foreach (var c in words[j])
                    {
                        array[idx++] = c;
                    }

                    if (idx < maxWidth)
                    {
                        array[idx++] = ' ';
                    }
                }

                for (; idx < maxWidth; idx++)
                {
                    array[idx] = ' ';
                }
            }
            else
            {
                var left = maxWidth - len;
                int space = left / (r - i - 1),
                    remain = left % (r - i - 1);
                int j = i;
                for (; j < r; j++)
                {
                    foreach (var c in words[j])
                    {
                        array[idx++] = c;
                    }

                    if (idx < maxWidth)
                    {
                        var s = space + (remain > 0 ? 1 : 0);
                        for (int z = 0; z <= s; z++)
                        {
                            array[idx++] = ' ';
                        }
                    }
                    remain--;
                }
            }
            
            result.Add(new string(array));
            i = r;
        }

        return result;
    }
}
// @lc code=end

