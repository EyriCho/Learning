/*
 * @lc app=leetcode id=1461 lang=csharp
 *
 * [1461] Check If a String Contains All Binary Codes of Size K
 */

// @lc code=start
public class Solution {
    public bool HasAllCodes(string s, int k) {
        int count = 1 << k;
        var found = new bool[count];
        int mask = count - 1,
            num = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            num <<= 1;
            if (s[i] == '1')
                num |= 1;
            num &= mask;
            
            if (i + 1 >= k && !found[num])
            {    
                found[num] = true;
                count--;
            }
        }
        
        
        return count == 0;
    }
}
// @lc code=end

