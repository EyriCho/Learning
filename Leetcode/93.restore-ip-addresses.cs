/*
 * @lc app=leetcode id=93 lang=csharp
 *
 * [93] Restore IP Addresses
 */

// @lc code=start
public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        var result = new List<string>();
        var path = new char[s.Length + 3];

        bool IsValid(string str)
        {
            if (str.Length == 0)
            {
                return false;
            }

            if (str[0] == '0' && str.Length > 1)
            {
                return false;
            }

            var val = int.Parse(str);
            return val < 256;
        }

        void FindAddress(int index, int part, int count)
        {
            if (part == 3)
            {
                if (s.Length - index < 4 && IsValid(s[index..]))
                {
                    for (int i = index; i < s.Length; i++)
                    {
                        path[count++] = s[i];
                    }
                    result.Add(new string(path));
                }
                return;
            }

            for (int i = 1; i < 4 && index + i < s.Length; i++)
            {
                if (IsValid(s[index..(index + i)]))
                {
                    for (int j = 0; j < i; j++)
                    {
                        path[count + j] = s[index + j];
                    }
                    path[count + i] = '.';
                    FindAddress(index + i, part + 1, count + i + 1);
                }
            }
        }

        FindAddress(0, 0, 0);
        return result;
    }
}
// @lc code=end

