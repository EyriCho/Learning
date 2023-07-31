/*
 * @lc app=leetcode id=1125 lang=csharp
 *
 * [1125] Smallest Sufficient Team
 */

// @lc code=start
public class Solution {
    public int[] SmallestSufficientTeam(string[] req_skills, IList<IList<string>> people) {
        var skills = new Dictionary<string, int>();
        for (int i = 0; i < req_skills.Length; i++)
        {
            skills[req_skills[i]] = i;
        }

        var dp = new Dictionary<int, List<int>>();
        dp[0] = new List<int>();
        for (int i = 0; i < people.Count; i++)
        {
            var s = 0;
            foreach (var skill in people[i])
            {
                s |= 1 << skills[skill];
            }

            var curr = dp.Select(d => (d.Key, d.Value)).ToList();
            foreach (var (currSkills, list) in curr)
            {
                var newSkills = currSkills | s;
                if (newSkills == currSkills)
                {
                    continue;
                }

                if (!dp.ContainsKey(newSkills) ||
                    dp[newSkills].Count > list.Count + 1)
                {
                    dp[newSkills] = new List<int>(list);
                    dp[newSkills].Add(i);
                }
            }

        }
        return dp[(1 << req_skills.Length) - 1].ToArray();
    }
}
// @lc code=end

