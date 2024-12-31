/*
 * @lc app=leetcode id=2337 lang=csharp
 *
 * [2337] Move Pieces to Obtain a String 
 */

// @lc code=start
public class Solution {
    public bool CanChange(string start, string target) {
        if (start == target)
        {
            return true;
        }

        int l = 0,
            r = 0;
        for (int i = 0; i < start.Length; i++)
        {
            if (start[i] == 'R')
            {
                if (l > 0)
                {
                    return false;
                }
                r++;
            }

            if (target[i] == 'L')
            {
                if (r > 0)
                {
                    return false;
                }
                l++;
            }
            else if (target[i] == 'R')
            {
                if (r == 0)
                {
                    return false;
                }
                r--;
            }

            if (start[i] == 'L')
            {
                if (l == 0)
                {
                    return false;
                }
                l--;
            }
        }

        return l == 0 && r == 0;
    }
}
// @lc code=end

