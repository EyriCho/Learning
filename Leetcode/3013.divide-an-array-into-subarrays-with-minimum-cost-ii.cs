/*
 * @lc app=leetcode id=3013 lang=csharp
 *
 * [3013] Divide an Array Into Subarrays With Minimum Cost II
 */

// @lc code=start
public class Solution {
    public long MinimumCost(int[] nums, int k, int dist) {
        MinList l = new (k - 1);
        for (int i = 1; i <= dist + 1; i++)
        {
            l.Insert(nums[i]);
        }
        long min = l.MinimumSum;

        for (int i = 1; i + dist + 1 < nums.Length; i++)
        {
            l.Insert(nums[i + dist + 1]);
            l.Remove(nums[i]);
            min = Math.Min(min, l.MinimumSum);
        }

        return nums[0] + min;
    }

    internal class MinList
    {
        private List<long> list;
        private int minSize;

        internal long MinimumSum { get; set; }

        internal MinList(int size)
        {
            minSize = size;
            list = new (size + 1);
        }

        private int BinarySearch(int num)
        {
            if (list.Count == 0)
            {
                return -1;
            }

            int l = 0, r = list.Count - 1,
                m = 0;
            
            if (list[r] < num)
            {
                return -1;
            }

            while (l < r)
            {
                m = (l + r) >> 1;
                if (list[m] < num)
                {
                    l = m + 1;
                }
                else
                {
                    r = m;
                }
            }

            return r;
        }

        internal void Insert(int num)
        {
            int idx = BinarySearch(num);
            if (idx >= 0)
            {
                list.Insert(idx, num);
            }
            else
            {
                list.Add(num);
                idx = list.Count - 1;
            }

            if (idx < minSize)
            {
                MinimumSum += num;
                if (minSize < list.Count)
                {
                    MinimumSum -= list[minSize];
                }
            }
        }

        internal void Remove(int num)
        {
            int idx = BinarySearch(num);
            if (idx >= 0)
            {
                if (idx < minSize)
                {
                    MinimumSum -= list[idx];
                    if (minSize < list.Count)
                    {
                        MinimumSum += list[minSize];
                    }
                }
                list.RemoveAt(idx);
            }
        }
    }
}
// @lc code=end

