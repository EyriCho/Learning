/*
 * @lc app=leetcode id=131 lang=csharp
 *
 * [131] Palindrome Partitioning
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> Partition(string s) {
        var result = new List<IList<string>>();
        var temp = new List<string>(s.Length);
        
        bool IsPalindrome (string str)
        {
            int l = 0, r = str.Length - 1;
            
            while (l < r)
            {
                if (str[l++] != str[r--])
                {
                    return false;
                }
            }
            
            return true;
        }
        
        void Dfs(int p)
        {
            if (p == s.Length)
            {
                result.Add(new List<string>(temp));
            }
            
            for (int i = p + 1; i <= s.Length; i++)
            {
                if (IsPalindrome(s[p..i]))
                {
                    temp.Add(s[p..i]);
                    Dfs(i);
                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }
        
        Dfs(0);
        
        return result;
    }
}
// @lc code=end

