/*
 * @lc app=leetcode id=1508 lang=csharp
 *
 * [1508] Range Sum of Sorted Subarray Sums
 */

// @lc code=start
public class Solution {
    public int RangeSum(int[] nums, int n, int left, int right) {
        (int, int)[] array = new (int, int)[Math.Max(n, right)];
        int length = 0;
        
        void Add(int sum, int index)
        {
            int i = length++,
                p = 0;
            array[i] = (sum, index);
            while (i > 0)
            {
                p = (i - 1) >> 1;
                if (array[i].Item1 >= array[p].Item1)
                {
                    break;
                }

                (int, int) temp = array[i];
                array[i] = array[p];
                array[p] = temp;

                i = p;
            }
        }

        (int, int) Pop()
        {
            (int, int) rst = array[0],
                temp = (0, 0);
            int l = 0,
                r = 0,
                i = 0;
            array[0] = array[--length];
            while (true)
            {
                l = i * 2 + 1;
                r = i * 2 + 2;
                if (l >= length)
                {
                    break;
                }

                if (array[l].Item1 < array[i].Item1 ||
                    (r < length && array[r].Item1 < array[i].Item1))
                {
                    if (r >= length || array[l].Item1 <= array[r].Item1)
                    {
                        temp = array[l];
                        array[l] = array[i];
                        array[i] = temp;
                        i = l;
                    }
                    else
                    {
                        temp = array[r];
                        array[r] = array[i];
                        array[i] = temp;
                        i = r;
                    }
                }
                else
                {
                    break;
                }
            }
            return rst;
        }

        for (int i = 0; i < n; i++)
        {
            Add(nums[i], i + 1);
        }

        long result = 0;
        for (int i = 1; i <= right; i++)
        {
            (int s, int index) = Pop();
            if (i >= left)
            {
                result = (result + s) % 1_000_000_007;
            }

            if (index < n)
            {
                Add(s + nums[index], index + 1);
            }
        }

        return (int)result;
    }
}
// @lc code=end

