/*
 * @lc app=leetcode id=1408 lang=csharp
 *
 * [1408] String Matching in an Array
 */

// @lc code=start
public class Solution {
    public IList<string> StringMatching(string[] words) {
        HashSet<string> set = new();
        List<string> result = new();

        foreach (string word in words)
        {
            foreach (string prev in set)
            {
                if (prev.Contains(word))
                {
                    result.Add(word);
                }
                
                if (word.Contains(prev))
                {
                    result.Add(prev);
                }
            }

            set.Add(word);
        }

        return result;
    }
}
// @lc code=end

