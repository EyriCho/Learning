/*
 * @lc app=leetcode id=2163 lang=csharp
 *
 * [2163] Minimum Difference in Sums After Removal of Elements
 */

// @lc code=start
public class Solution {
    public long MinimumDifference(int[] nums) {
        int n = nums.Length / 3;
        long[] front = new long[n + 1],
            back = new long[n + 1];
        
        PriorityQueue<int, int> minStack = new (),
            maxStack = new (Comparer<int>.Create((a, b) => b.CompareTo(a)));
        long min = 0L,
            max = 0L;
        
        int f = 0,
            b = 0;
        for (int i = 0; i < n; i++)
        {
            min += nums[i];
            maxStack.Enqueue(nums[i], nums[i]);

            b = nums[nums.Length - 1 - i];
            max += b;
            minStack.Enqueue(b, b);
        }
        front[0] = min;
        back[^1] = max;

        for (int i = 0; i < n; i++)
        {
            f = nums[n + i];
            min += f;
            maxStack.Enqueue(f, f);
            min -= maxStack.Dequeue();
            front[1 + i] = min;

            b = nums[nums.Length - 1 - n - i];
            max += b;
            minStack.Enqueue(b, b);
            max -= minStack.Dequeue();
            back[back.Length - 2 - i] = max;
        }

        long result = long.MaxValue;
        for (int i = 0; i < front.Length; i++)
        {
            result = Math.Min(result, front[i] - back[i]);
        }
        return result;
    }
}
// @lc code=end

