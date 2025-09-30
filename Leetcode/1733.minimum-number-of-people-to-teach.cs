/*
 * @lc app=leetcode id=1733 lang=csharp
 *
 * [1733] Minimum Number of People to Teach
 */

// @lc code=start
public class Solution {
    public int MinimumTeachings(int n, int[][] languages, int[][] friendships) {
        HashSet<int>[] users = new HashSet<int>[languages.Length + 1];
        for (int u = 1; u <= languages.Length; u++)
        {
            users[u] = new (languages[u - 1]);
        }
        
        HashSet<int> cannotComm = new ();
        bool canComm = false;
        foreach (int[] friendship in friendships)
        {
            canComm = false;
            foreach (int uLanguage in users[friendship[0]])
            {
                if (users[friendship[1]].Contains(uLanguage))
                {
                    canComm = true;
                    break;
                }
            }

            if (!canComm)
            {
                cannotComm.Add(friendship[0]);
                cannotComm.Add(friendship[1]);
            }
        }

        if (cannotComm.Count == 0)
        {
            return 0;
        }

        int[] lans = new int[n + 1];
        foreach (int u in cannotComm)
        {
            foreach (int l in users[u])
            {
                lans[l]++;
            }
        }

        int result = cannotComm.Count;
        for (int l = 1; l <= n; l++)
        {
            result = Math.Min(result, cannotComm.Count - lans[l]);
        }
        return result;
    }
}
// @lc code=end

