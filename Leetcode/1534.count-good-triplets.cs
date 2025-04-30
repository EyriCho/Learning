/*
 * @lc app=leetcode id=1534 lang=csharp
 *
 * [1534] Count Good Triplets
 */

// @lc code=start
public class Solution {
    public int CountGoodTriplets(int[] arr, int a, int b, int c) {
        int result = 0,
            l = 0, lj = 0, lk = 0,
            r = 0, rj = 0, rk = 0;
        int[] prefixCount = new int[1001];
        for (int j = 0; j < arr.Length; j++)
        {
            for (int k = j + 1; k < arr.Length; k++)
            {
                if (Math.Abs(arr[j] - arr[k]) <= b)
                {
                    lj = arr[j] - a;
                    lk = arr[k] - c;
                    rj = arr[j] + a;
                    rk = arr[k] + c;
                    l = Math.Max(0, Math.Max(lj, lk));
                    r = Math.Min(1000, Math.Min(rj, rk));

                    if (l <= r)
                    {
                        result += prefixCount[r] - (l > 0 ? prefixCount[l - 1] : 0);
                    }
                }
            }

            for (int num = arr[j]; num < 1001; num++)
            {
                prefixCount[num]++;
            }
        }

        return result;
    }
}
// @lc code=end

