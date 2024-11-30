/*
 * @lc app=leetcode id=796 lang=csharp
 *
 * [796] Rotate String
 */

// @lc code=start
public class Solution {
    public bool RotateString(string s, string goal) {
        if (s.Length != goal.Length)
        {
            return false;
        }
        
        int origin = 0,
            match = 0;
        for (int i = 0; i < s.Length; i++)
        {
            origin = i;
            match = 0;
            while (match < goal.Length)
            {
                if (s[origin++] != goal[match])
                {
                    break;
                }

                match++;
                if (origin == s.Length)
                {
                    origin = 0;
                }
            }

            if (match == goal.Length)
            {
                return true;
            }
        }

        return false;
    }
}
// @lc code=end

