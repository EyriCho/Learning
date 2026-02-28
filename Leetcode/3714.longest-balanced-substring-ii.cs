/*
 * @lc app=leetcode id=3714 lang=csharp
 *
 * [3714] Longest Balanced Substring II
 */

// @lc code=start
public class Solution {
    public int LongestBalanced(string s) {
        int result = 0,
            a = 0, b = 0, c = 0,
            ab = 0, ac = 0;

        Dictionary<(int, int), int> triDict = new ();
        triDict[(0, 0)] = -1;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
            {
                a++;
                b = 0;
                c = 0;
                ab++;
                ac++;
            }
            else if (s[i] == 'b')
            {
                a = 0;
                b++;
                c = 0;
                ab--;
            }
            else
            {
                a = 0;
                b = 0;
                c++;
                ac--;
            }

            result = Math.Max(result, a);
            result = Math.Max(result, b);
            result = Math.Max(result, c);

            if (triDict.ContainsKey((ab, ac)))
            {
                result = Math.Max(result, i - triDict[(ab, ac)]);
            }
            else
            {
                triDict[(ab, ac)] = i;
            }
        }

        int CountTwin(char first, char second)
        {
            Dictionary<int, int> dict = new ();
            dict[0] = -1;
            int p = 0,
                rst = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != first && s[i] != second)
                {
                    dict.Clear();
                    dict[0] = i;
                    p = 0;
                    continue;
                }

                p += s[i] == first ? 1 : -1;

                if (dict.ContainsKey(p))
                {
                    rst = Math.Max(rst, i - dict[p]);
                }
                else
                {
                    dict[p] = i;
                }
            }
            return rst;
        }

        result = Math.Max(result, CountTwin('a', 'b'));
        result = Math.Max(result, CountTwin('b', 'c'));
        result = Math.Max(result, CountTwin('a', 'c'));

        return result;
    }
}
// @lc code=end

