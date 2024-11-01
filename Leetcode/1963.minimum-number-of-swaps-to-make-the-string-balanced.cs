/*
 * @lc app=leetcode id=1963 lang=csharp
 *
 * [1963] Minimum Number of Swaps to Make the String Balanced
 */

// @lc code=start
public class Solution {
    public int MinSwaps(string s) {
        int l = 0,
            r = 0;
        
        foreach (char c in s)
        {
            if (c == '[')
            {
                l++;
            }
            else
            {
                if (l > 0)
                {
                    l--;
                }
                else
                {
                    r++;
                }
            }
        }

        return r / 2 + r % 2;
    }
}
// @lc code=end

