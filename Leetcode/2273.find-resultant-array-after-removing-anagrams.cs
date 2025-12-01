/*
 * @lc app=leetcode id=2273 lang=csharp
 *
 * [2273] Find Resultant Array After Removing Anagrams
 */

// @lc code=start
public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
        int[,] cs = new int[words.Length, 26];
        for (int i = 0; i < words.Length; i++)
        {
            foreach (char c in words[i])
            {
                cs[i, c - 'a']++;
            }
        }

        List<string> result = new ();
        int idx = 0, nxt = 0;
        bool same = true;
        while (idx < words.Length)
        {
            result.Add(words[idx]);
            nxt = idx + 1;
            while (nxt < words.Length)
            {
                same = true;
                for (int c = 0; c < 26; c++)
                {
                    if (cs[idx, c] != cs[nxt, c])
                    {
                        same = false;
                        break;
                    }
                }

                if (!same)
                {
                    break;
                }
                nxt++;
            }

            idx = nxt;
        }

        return result;
    }
}
// @lc code=end

