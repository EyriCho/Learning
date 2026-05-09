/*
 * @lc app=leetcode id=657 lang=csharp
 *
 * [657] Robot Return to Origin
 */

// @lc code=start
public class Solution {
    public bool JudgeCircle(string moves) {
        int r = 0, c = 0;
        foreach (char m in moves)
        {
            switch (m)
            {
                case 'R':
                    c++;
                    break;
                case 'L':
                    c--;
                    break;
                case 'U':
                    r--;
                    break;
                case 'D':
                    r++;
                    break;
                default:
                    break;
            }
        }
        return r == 0 && c == 0;
    }
}
// @lc code=end

