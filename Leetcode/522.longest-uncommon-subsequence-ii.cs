/*
 * @lc app=leetcode id=522 lang=csharp
 *
 * [522] Longest Uncommon Subsequence II
 */

// @lc code=start
public class Solution {
    public int FindLUSlength(string[] strs) {
        var set = new HashSet<string>();
        
        Array.Sort(strs, (a, b) => {
            if (a.Length == b.Length)
                return string.Compare(b, a);
            return b.Length - a.Length;
        });
        
        for (int i = 0; i < strs.Length; i++)
        {
            if (i == strs.Length - 1 || strs[i] != strs[i + 1])
            {
                bool found = true;
                foreach (var s in set)
                {
                    int j = 0;
                    foreach (var c in s)
                    {
                        if (c == strs[i][j])
                            j++;
                        if (j == strs[i].Length)
                            break;
                    }
                    
                    if (j == strs[i].Length)
                    {
                        found = false;
                        break;
                    }
                }
                
                if (found)
                    return strs[i].Length;
            }
            set.Add(strs[i]);
        }
            
        return -1;
    }
}
// @lc code=end

