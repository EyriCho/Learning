/*
 * @lc app=leetcode id=1900 lang=csharp
 *
 * [1900] The Earliest and Latest Rounds Where Players Compete
 */

// @lc code=start
public class Solution {
    public int[] EarliestAndLatest(int n, int firstPlayer, int secondPlayer) {
        if (n - secondPlayer + 1 == firstPlayer)
        {
            return new int[] { 1, 1 };
        }
        if (n <= 4)
        {
            return new int[] { 2, 2 };
        }

        int p1 = 0, p2 = 0;
        if (firstPlayer <= secondPlayer)
        {
            p1 = firstPlayer;
            p2 = secondPlayer;
        }
        else
        {
            p1 = secondPlayer;
            p2 = firstPlayer;
        }
        
        if (p1 - 1 > n - p2)
        {
            int temp = n + 1 - p1;
            p1 = n + 1 - p2;
            p2 = temp;
        }

        int nextRound = (n + 1) >> 1,
            min = n,
            max = 1;
        
        int[] next = null;
        if (p2 * 2 <= n + 1)
        {
            int mid = p2 - p1 - 1;
            for (int i = 0; i < p1; i++)
            {
                for (int j = 0; j <= mid; j++)
                {
                    next = EarliestAndLatest(nextRound, i + 1, i + j + 2);
                    min = Math.Min(min, next[0] + 1);
                    max = Math.Max(max, next[1] + 1);
                }
            }
        }
        else
        {
            int p2Mirrored = n + 1 - p2,
                mid = p2Mirrored - p1 - 1,
                midStick = (p2 - p2Mirrored) >> 1;

            for (int i = 0; i < p1; i++)
            {
                for (int j = 0; j <= mid; j++)
                {
                    next = EarliestAndLatest(nextRound, i + 1, i + 1 + j + 1 + midStick);
                    min = Math.Min(min, next[0] + 1);
                    max = Math.Max(max, next[1] + 1);
                }
            }
        }

        return new int[] { min, max };
    }
}
// @lc code=end

