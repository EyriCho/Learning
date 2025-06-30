/*
 * @lc app=leetcode id=1298 lang=csharp
 *
 * [1298] Maximum Candies You Can Get from Boxes
 */

// @lc code=start
public class Solution {
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes) {
        Queue<int> queue = new ();
        HashSet<int> needKeys = new ();
        foreach (int b in initialBoxes)
        {
            if (status[b] == 1)
            {
                queue.Enqueue(b);
            }
            else
            {
                needKeys.Add(b);
            }
        }

        int result = 0,
            box = 0;
        while (queue.Count > 0)
        {
            box = queue.Dequeue();
            result += candies[box];

            foreach (int b in containedBoxes[box])
            {
                if (status[b] == 1)
                {
                    queue.Enqueue(b);
                }
                else
                {
                    needKeys.Add(b);
                }
            }

            foreach (int k in keys[box])
            {
                if (needKeys.Contains(k))
                {
                    needKeys.Remove(k);
                    queue.Enqueue(k);
                }
                else if (status[k] == 0)
                {
                    status[k] = 1;
                }
            }
        }

        return result;
    }
}
// @lc code=end

