/*
 * @lc app=leetcode id=1122 lang=csharp
 *
 * [1122] Relative Sort Array
 */

// @lc code=start
public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        int[] counts = new int[1001];
        foreach (int num in arr1)
        {
            counts[num]++;
        }

        int i = 0;
        foreach (int num in arr2)
        {
            while (counts[num] > 0)
            {
                arr1[i++] = num;
                counts[num]--;
            }
        }

        for (int num = 0; num < 1001; num++)
        {
            while (counts[num] > 0)
            {
                arr1[i++] = num;
                counts[num]--;
            }
        }

        return arr1;
    }
}
// @lc code=end

