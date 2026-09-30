/*
 * @lc app=leetcode id=1807 lang=csharp
 *
 * [1807] Evaluate the Bracket Pairs of a String
 */

// @lc code=start
public class Solution {
    public string Evaluate(string s, IList<IList<string>> knowledge) {
        Dictionary<string, string> dict = knowledge.ToDictionary(pair => pair[0],
            pair => pair[1]);

        StringBuilder sb = new ();
        
        for (int l = 0, r = 0; l < s.Length; l++)
        {
            if (s[l] != '(')
            {
                sb.Append(s[l]);
                continue;
            }

            l++;
            r = l;
            while (s[r] != ')')
            {
                r++;
            }

            if (dict.TryGetValue(s[l..r], out string val))
            {
                sb.Append(val);
            }
            else
            {
                sb.Append('?');
            }

            l = r;
        }

        return sb.ToString();
    }
}
// @lc code=end

