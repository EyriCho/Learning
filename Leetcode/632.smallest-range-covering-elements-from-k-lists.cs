/*
 * @lc app=leetcode id=632 lang=csharp
 *
 * [632] Smallest Range Covering Elements from K Lists
 */

// @lc code=start
public class Solution {
    public int[] SmallestRange(IList<IList<int>> nums) {
        int[] indexes = new int[nums.Count];
        int max = -100_000;
        PriorityQueue<int, int> queue = new ();
        for (int i = 0; i < nums.Count; i++)
        {
            queue.Enqueue(i, nums[i][0]);
            max = Math.Max(max, nums[i][0]);
        }

        int[] result = new int[] {
            -100_000,
            100_000
        };
        int minList = 0;
        while (true)
        {
            minList = queue.Dequeue();
            if (result[1] - result[0] > max - nums[minList][indexes[minList]])
            {
                result[0] = nums[minList][indexes[minList]];
                result[1] = max;
            }
            indexes[minList]++;
            if (indexes[minList] == nums[minList].Count)
            {
                break;
            }
            queue.Enqueue(minList, nums[minList][indexes[minList]]);
            max = Math.Max(max, nums[minList][indexes[minList]]);
        }
        
        return result;
    }
}
// @lc code=end

