/*
 * @lc app=leetcode id=131 lang=csharp
 *
 * [131] Palindrome Partitioning
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> Partition(string s) {
        var result = new List<IList<string>>();
        var temp = new List<string>();
        
        Partition(s, 0, result, temp);
        
        return result;
    }
    
    private void Partition(string s, int start, IList<IList<string>> result, IList<string> temp)
    {
        if (start == s.Length)
            result.Add(new List<string>(temp));
        
        for (int i = start + 1; i <= s.Length; i++)
        {
            if (!IsPalindrome(s[start..i]))
                continue;
            
            temp.Add(s[start..i]);
            Partition(s, i, result, temp);
            temp.RemoveAt(temp.Count - 1);
        }
    }
    
    private bool IsPalindrome(string s)
    {
        int l = 0, r = s.Length - 1;
        while (l < r)
            if (s[l++] != s[r--])
                return false;
        return true;
    }
}
// @lc code=end

