/*
 * @lc app=leetcode id=76 lang=csharp
 *
 * [76] Minimum Window Substring
 */

// @lc code=start
public class Solution {
    public string MinWindow(string s, string t) {
        int[] counts = new int[128];
        int[] current = new int[128];
        foreach (char c in t)
        {
            counts[c - 'A']++;
        }
        
        int l = 0, minL = 0,
            length = int.MaxValue,
            tCount = t.Length;
        
        for (int r = 0; r < s.Length; r++)
        {
            int c = s[r] - 'A';
            if (counts[c] > 0)
            {
                current[c]++;
                if (current[c] <= counts[c])
                {
                    tCount--;
                }
            }
            
            if (tCount == 0)
            {
                while (true)
                {
                    c = s[l] - 'A';
                    if (counts[c] > 0)
                    {
                        if (current[c] > counts[c])
                        {
                            current[c]--;
                        }
                        else
                        {
                            break;
                        }
                    }
                    l++;
                }
                
                if (length > r - l + 1)
                {
                    length = r - l + 1;
                    minL = l;
                }
            }
        }
        
        if (length > s.Length)
        {
            return string.Empty;
        }
        
        return s[minL..(minL + length)];
    }
}
// @lc code=end

