/*
 * @lc app=leetcode id=1095 lang=csharp
 *
 * [1095] Find in Mountain Array
 */

// @lc code=start
/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {
        int l = 0, r = mountainArr.Length() - 1;
        while (l + 1 < r)
        {
            var m = (l + r) >> 1;

            if (mountainArr.Get(m) > mountainArr.Get(m - 1))
            {
                l = m;
            }
            else
            {
                r = m;
            }
        }

        var high = mountainArr.Get(l) > mountainArr.Get(r) ? l : r;

        l = 0;
        r = high;
        while (l <= r)
        {
            var m = (l + r) >> 1;
            var mid = mountainArr.Get(m);
            if (mid == target)
            {
                return m;
            }
            else if (target > mid)
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }

        l = high + 1;
        r = mountainArr.Length() - 1;
        while (l <= r)
        {
            var m = (l + r) >> 1;
            var mid = mountainArr.Get(m);
            if (mid == target)
            {
                return m;
            }
            else if (target > mid)
            {
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }

        return -1;
    }
}
// @lc code=end

