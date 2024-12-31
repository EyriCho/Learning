/*
 * @lc app=leetcode id=2558 lang=csharp
 *
 * [2558] Take Gift From the Richest Pile
 */

// @lc code=start
public class Solution {
    public long PickGifts(int[] gifts, int k) {
        PriorityQueue<int, int> queue = new (Comparer<int>.Create((a, b) => b.CompareTo(a)));
        long result = 0L;
        foreach (int gift in gifts)
        {
            result += gift;
            queue.Enqueue(gift, gift);
        }

        int pile = 0, left = 0;
        while (k-- > 0)
        {
            pile = queue.Dequeue();
            left = (int)Math.Sqrt(pile);
            result -= pile - left;
            queue.Enqueue(left, left);
        }

        return result;
    }
}
// @lc code=end

