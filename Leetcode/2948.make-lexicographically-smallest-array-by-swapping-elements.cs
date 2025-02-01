/*
 * @lc app=leetcode id=2948 lang=csharp
 *
 * [2948] Make Lexicographically Smallest Array by Swapping Elements
 */

// @lc code=start
public class Solution {
    public int[] LexicographicallySmallestArray(int[] nums, int limit) {
        List<int> list = nums.ToList();
        list.Sort();

        Dictionary<int, Queue<int>> dict = new ();
        dict[list[0]] = new ();
        dict[list[0]].Enqueue(list[0]);
        for (int i = 1; i < list.Count; i++)
        {
            if (Math.Abs(list[i] - list[i - 1]) <= limit)
            {
                dict[list[i - 1]].Enqueue(list[i]);
                dict[list[i]] = dict[list[i - 1]];
            }
            else
            {
                dict[list[i]] = new ();
                dict[list[i]].Enqueue(list[i]);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = dict[nums[i]].Dequeue();
        }

        return nums;
    }
}
// @lc code=end

