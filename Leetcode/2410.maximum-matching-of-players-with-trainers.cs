/*
 * @lc app=leetcode id=2410 lang=csharp
 *
 * [2410] Maximum Matching of Players With Trainers
 */

// @lc code=start
public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
        Array.Sort(players);
        Array.Sort(trainers);

        int p = 0, t = 0,
            result = 0;
        
        while (p < players.Length)
        {
            while (t < trainers.Length &&
                trainers[t] < players[p])
            {
                t++;
            }
            if (t == trainers.Length)
            {
                break;
            }
            result++;
            p++;
            t++;
        }

        return result;
    }
}
// @lc code=end

