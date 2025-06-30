/*
 * @lc app=leetcode id=2138 lang=csharp
 *
 * [2138] Divide a String Into Groups of Size k
 */

// @lc code=start
public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        int length = 0,
            last = 0;
        if (s.Length % k == 0)
        {
            length = s.Length / k;
            last = length;
        }
        else
        {
            length = s.Length / k + 1;
            last = length - 1;
        }
        
        string[] result = new string[length];
        for (int i = 0; i < last; i++)
        {
            result[i] = s[(i * k)..((i + 1) * k)];
        }

        if (s.Length % k != 0)
        {
            char[] array = new char[k];
            for (int i = 0, j = (length - 1) * k; i < k; i++)
            {
                if (j < s.Length)
                {
                    array[i] = s[j++];
                }
                else
                {
                    array[i] = fill;
                }
            }
            result[^1] = new string(array);
        }
        return result;
    }
}
// @lc code=end

