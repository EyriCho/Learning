/*
 * @lc app=leetcode id=2491 lang=csharp
 *
 * [2491] Divide Players Into Teams of Equal Skill
 */

// @lc code=start
public class Solution {
    public long DividePlayers(int[] skill) {
        Array.Sort(skill);
        int l = 0,
            r = skill.Length - 1;
        int team = skill[l] + skill[r];
        
        long sum = 0L;
        while (l < r)
        {
            if (skill[l] + skill[r] != team)
            {
                return -1L;
            }

            sum += skill[l++] * skill[r--];
        }
        
        return sum;
    }
}
// @lc code=end

