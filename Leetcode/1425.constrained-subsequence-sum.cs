/*
 * @lc app=leetcode id=1425 lang=csharp
 *
 * [1425] Constrained Subsequence Sum
 */

// @lc code=start
public class Solution {
    public int ConstrainedSubsetSum(int[] nums, int k) {
        var result = int.MinValue;
        var dp = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            dp[i] = nums[i];
            result = Math.Max(result, nums[i]);
        }

        var length = 0;
        var array = new (int, int)[nums.Length + 1];
        void Add(int index, int sum)
        {
            var i = length++;
            array[i] = (index, sum);
            while (i > 0)
            {
                int p = (i - 1) >> 1;
                if (array[i].Item2 <= array[p].Item2)
                {
                    return;
                }

                var tmp = array[i];
                array[i] = array[p];
                array[p] = tmp;
                i = p;
            }
        }

        void Pop()
        {
            array[0] = array[--length];
            int i = 0;

            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;

                if (l >= length)
                {
                    break;
                }

                if (array[i].Item2 < array[l].Item2 ||
                    (r < length && array[i].Item2 < array[r].Item2))
                {
                    if (r >= length || array[l].Item2 >= array[r].Item2)
                    {
                        var tmp = array[i];
                        array[i] = array[l];
                        array[l] = tmp;
                        i = l;
                    }
                    else
                    {
                        var tmp = array[i];
                        array[i] = array[r];
                        array[r] = tmp;
                        i = r;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        Add(0, nums[0]);
        for (int i = 1; i < nums.Length; i++)
        {
            int minPrev = Math.Max(0, i - k);
            while (length > 0 && array[0].Item1 < minPrev)
            {
                Pop();
            }
            dp[i] = Math.Max(dp[i], nums[i] + array[0].Item2);
            result = Math.Max(result, dp[i]);
            Add(i, dp[i]);
        }
        return result;
    }
}
// @lc code=end

