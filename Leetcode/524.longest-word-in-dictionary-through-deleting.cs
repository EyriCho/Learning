/*
 * @lc app=leetcode id=524 lang=csharp
 *
 * [524] Longest Word in Dictionary through Deleting
 */

// @lc code=start
public class Solution {
    public string FindLongestWord(string s, IList<string> d) {
        var result = string.Empty;
        foreach (var target in d)
        {
            int i = 0, j = 0;
            for (; i < s.Length; i++)
            {
                if (s[i] == target[j])
                    j++;
                
                if (j == target.Length)
                    break;
            }
            
            if (j == target.Length &&
               (target.Length > result.Length ||
                (target.Length == result.Length && target.CompareTo(result) < 0)))
                result = target;
        }
        
        return result;
    }
}
// @lc code=end

