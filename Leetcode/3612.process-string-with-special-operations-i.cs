/*
 * @lc app=leetcode id=3612 lang=csharp
 *
 * [3612] Process String with Special Operations I
 */

// @lc code=start
public class Solution {
    public string ProcessStr(string s) {
        List<char> list = new ();

        foreach (char c in s)
        {
            if (c == '*')
            {
                if (list.Count > 0)
                {
                    list.RemoveAt(list.Count - 1);
                }
            }
            else if (c == '#')
            {
                list.AddRange(list);
            }
            else if (c == '%')
            {
                list.Reverse();
            }
            else
            {
                list.Add(c);
            }
        }

        return new string(list.ToArray());
    }
}
// @lc code=end

