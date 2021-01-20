/*
 * @lc app=leetcode id=394 lang=csharp
 *
 * [394] Decode String
 */

// @lc code=start
public class Solution
{
    public string DecodeString(string s)
    {
        var result = Decode(s.ToCharArray());
        return new string(result.ToArray());
    }

    private List<char> Decode(char[] s)
    {
        List<char> result = new List<char>();

        int i = 0;
        while (i < s.Length)
        {
            while (i < s.Length && s[i] >= 'a' && s[i] <= 'z')
                result.Add(s[i++]);

            var times = 0;
            while (i < s.Length && s[i] != '[')
                times = times * 10 + (s[i++] - '0');

            var start = ++i;
            var count = 0;
            while (i < s.Length)
            {
                if (s[i] == '[')
                    count++;
                else if (s[i] == ']' && count-- == 0)
                    break;
                i++;
            }

            if (i >= s.Length)
                return result;

            var repeat = Decode(s[start..++i]);

            for (int j = 0; j < times; j++)
            {
                result.AddRange(repeat);
            }
        }

        return result;
    }
}
// @lc code=end

