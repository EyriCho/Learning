/*
 * @lc app=leetcode id=2593 lang=csharp
 *
 * [2593] Find Score of an Array After Marking All Elements
 */

// @lc code=start
public class Solution {
    public long FindScore(int[] nums) {
        PriorityQueue<int, int> queue = new (
            Comparer<int>.Create((a, b) => nums[a] == nums[b] ? a.CompareTo(b) : nums[a].CompareTo(nums[b]))
        );

        for (int i = 0; i < nums.Length; i++)
        {
            queue.Enqueue(i, i);
        }

        bool[] visited = new bool[nums.Length];
        long result = 0L;
        int idx = 0;
        while (queue.Count > 0)
        {
            idx = queue.Dequeue();
            if (visited[idx])
            {
                continue;
            }

            visited[idx] = true;
            if (idx > 0)
            {
                visited[idx - 1] = true;
            }
            if (idx < nums.Length - 1)
            {
                visited[idx + 1] = true;
            }
            result += nums[idx];
        }

        return result;
    }
}
// @lc code=end

