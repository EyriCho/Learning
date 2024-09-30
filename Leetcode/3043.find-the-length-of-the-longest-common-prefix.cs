/*
 * @lc app=leetcode id=3043 lang=csharp
 *
 * [3043] Find the Length of the Longest Common Prefix
 */

// @lc code=start
public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        int max = 0;
        HashSet<int> set = new ();

        for (int i = 0; i < arr1.Length; i++)
        {
            while (arr1[i] > 0)
            {
                if (!set.Add(arr1[i]))
                {
                    break;
                }
                arr1[i] /= 10;
            }
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            while (arr2[i] > 0)
            {
                if (set.Contains(arr2[i]))
                {
                    max = Math.Max(max, arr2[i]);
                    break;
                }

                arr2[i] /= 10;
            }
        }

        return max == 0 ? 0 : max.ToString().Length;
    }
}
// @lc code=end

