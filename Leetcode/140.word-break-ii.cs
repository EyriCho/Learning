/*
 * @lc app=leetcode id=140 lang=csharp
 *
 * [140] Word Break II
 */

// @lc code=start
public class Solution {
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        List<string> result = new (),
            temp = new ();
        HashSet<string> wordSet = new (wordDict);

        void Dfs(int index)
        {
            if (index == s.Length)
            {
                result.Add(string.Join(' ', temp));
                return;
            }

            for (int i = index + 1; i <= s.Length; i++)
            {
                if (!wordSet.Contains(s[index..i]))
                {
                    continue;
                }

                temp.Add(s[index..i]);
                Dfs(i);
                temp.RemoveAt(temp.Count - 1);
            }
        }

        Dfs(0);

        return result;
    }
}
// @lc code=end

