/*
 * @lc app=leetcode id=2942 lang=csharp
 *
 * [2942] Find Words Containing Character
 */

// @lc code=start
public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> result = new ();
        for (int i = 0; i < words.Length; i++)
        {
            foreach (char c in words[i])
            {
                if (c == x)
                {
                    result.Add(i);
                    break;
                }
            }
        }
        return result;
    }
}
// @lc code=end

