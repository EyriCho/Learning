/*
 * @lc app=leetcode id=2448 lang=csharp
 *
 * [2448] Minimum Cost to Make Array Equal
 */

// @lc code=start
public class Solution {
    public long MinCost(int[] nums, int[] cost) {
        var array = new (int, int)[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            array[i] = (nums[i], cost[i]);
        }

        Array.Sort(array, (a, b) =>
            a.Item1 - b.Item1
        );

        long[] preChange = new long[nums.Length],
            sufChange = new long[nums.Length];

        long preCost = 0, sufCost = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            preCost += array[i - 1].Item2;
            preChange[i] = preChange[i - 1] +
                preCost * (array[i].Item1 - array[i - 1].Item1);

            sufCost += array[nums.Length - i].Item2;
            sufChange[nums.Length - 1 - i] = sufChange[nums.Length - i] +
                sufCost * (array[nums.Length - i].Item1 - array[nums.Length - 1 - i].Item1);
        }

        var result = long.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            result = Math.Min(result, preChange[i] + sufChange[i]);
        }
        return result;
    }
}
// @lc code=end

