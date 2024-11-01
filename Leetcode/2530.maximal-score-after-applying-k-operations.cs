/*
 * @lc app=leetcode id=2530 lang=csharp
 *
 * [2530] Maximal Score After Applying K Operations
 */

// @lc code=start
public class Solution {
    public long MaxKelements(int[] nums, int k) {
        PriorityQueue<int, int> queue = new (
            Comparer<int>.Create((a, b) => b.CompareTo(a))
        );
        foreach (int num in nums)
        {
            queue.Enqueue(num, num);
        }

        long result = 0L;
        int next = 0;

        while (k-- > 0)
        {
            next = queue.Peek() / 3 + (queue.Peek() % 3 == 0 ? 0 : 1);
            result += queue.DequeueEnqueue(next, next);x.....
        }

        return result;
    }
}
// @lc code=end

