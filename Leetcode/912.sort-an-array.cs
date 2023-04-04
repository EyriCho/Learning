/*
 * @lc app=leetcode id=912 lang=csharp
 *
 * [912] Sort an Array
 */

// @lc code=start
public class Solution {
    public int[] SortArray(int[] nums) {
        var tmp = new int[nums.Length];
        void MergeSort(int[] arr, int begin, int end)
        {
            if (begin >= end)
            {
                return;
            }

            int mid = (begin + end) >> 1;
            MergeSort(arr, begin, mid);
            MergeSort(arr, mid + 1, end);

            int k = 0,
                i = begin, j = mid + 1;
            while (i <= mid && j <= end)
            {
                if (arr[i] <= arr[j])
                {
                    tmp[k++] = arr[i++];
                }
                else
                {
                    tmp[k++] = arr[j++];
                }
            }

            while (i <= mid)
            {
                tmp[k++] = arr[i++];
            }
            while (j <= end)
            {
                tmp[k++] = arr[j++];
            }

            for (; --k > -1; end--)
            {
                arr[end] = tmp[k];
            }
        }

        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }
}
// @lc code=end

