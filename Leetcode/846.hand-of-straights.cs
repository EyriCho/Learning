/*
 * @lc app=leetcode id=846 lang=csharp
 *
 * [846] Hand of Straights
 */

// @lc code=start
public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if (hand.Length % groupSize != 0)
        {
            return false;
        }

        SortedDictionary<int, int> dict = new ();
        foreach (int h in hand)
        {
            dict.TryGetValue(h, out int c);
            dict[h] = c + 1;
        }

        int min = 0;
        while (dict.Count > 0)
        {
            min = dict.First().Key;

            if (dict[min] == 0)
            {
                dict.Remove(min);
                continue;
            }

            for (int i = 1; i < groupSize; i++)
            {
                dict.TryGetValue(min + i, out int c);
                if (c < dict[min])
                {
                    return false;
                }

                dict[min + i] = c - dict[min];
            }

            dict.Remove(min);
        }

        return true;
    }
}
// @lc code=end

