/*
 * @lc app=leetcode id=649 lang=csharp
 *
 * [649] Dota2 Senate
 */

// @lc code=start
public class Solution {
    public string PredictPartyVictory(string senate) {
        var radQueue = new Queue<int>();
        var dirQueue = new Queue<int>();

        for (int i = 0; i < senate.Length; i++)
        {
            if (senate[i] == 'R')
            {
                radQueue.Enqueue(i);
            }
            else
            {
                dirQueue.Enqueue(i);
            }
        }

        while (radQueue.Count > 0 && dirQueue.Count > 0)
        {
            var r = radQueue.Dequeue();
            var d = dirQueue.Dequeue();
            if (r < d)
            {
                radQueue.Enqueue(r + senate.Length);
            }
            else
            {
                dirQueue.Enqueue(d + senate.Length);
            }
        }

        return radQueue.Count > dirQueue.Count ? "Radiant" : "Dire";
    }
}
// @lc code=end

