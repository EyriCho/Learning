/*
 * @lc app=leetcode id=239 lang=csharp
 *
 * [239] Sliding Window Maximum
 */

// @lc code=start
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var array = new int[nums.Length];
        var length = 0;

        void Add(int index)
        {
            int i = length++;
            array[i] = index;
            while (i > 0)
            {
                var p = (i - 1) >> 1;
                if (nums[array[i]] > nums[array[p]])
                {
                    array[i] ^= array[p];
                    array[p] ^= array[i];
                    array[i] ^= array[p];
                }
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

                if (nums[array[i]] < nums[array[l]] ||
                    (r < length && nums[array[i]] < nums[array[r]]))
                {
                    if (r >= length || nums[array[l]] > nums[array[r]])
                    {
                        array[i] ^= array[l];
                        array[l] ^= array[i];
                        array[i] ^= array[l];
                        i = l;
                    }
                    else
                    {
                        array[i] ^= array[r];
                        array[r] ^= array[i];
                        array[i] ^= array[r];
                        i = r;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        var result = new int[nums.Length - k + 1];
        for (int i = 0; i < k - 1; i++)
        {
            Add(i);
        }

        for (int i = 0; i + k <= nums.Length; i++)
        {
            Add(i + k - 1);
            while (length > 0 && array[0] < i)
            {
                Pop();
            }
            result[i] = nums[array[0]];
        }

        return result;
    }
}
// @lc code=end

