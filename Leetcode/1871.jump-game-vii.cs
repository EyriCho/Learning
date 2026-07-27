/*
 * @lc app=leetcode id=1871 lang=csharp
 *
 * [1871] Jump Game VII
 */

// @lc code=start
public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {
        if (s[^1] == '1')
        {
            return false;
        }

        bool[] reachable = new bool[s.Length];
        reachable[0] = true;

        int windowCount = 0;

        for (int i = 1; i < s.Length; i++)
        {
            if (i >= minJump && reachable[i - minJump])
            {
                windowCount++;
            }

            if (i > maxJump && reachable[i - maxJump - 1])
            {
                windowCount--;
            }

            if (s[i] == '0' && windowCount > 0)
            {
                reachable[i] = true;
            }
        }

        return reachable[^1];
    }
}
// @lc code=end

