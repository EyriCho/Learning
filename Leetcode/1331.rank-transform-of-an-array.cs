/*
 * @lc app=leetcode id=1331 lang=csharp
 *
 * [1331] Rank Transform of an Array
 */

// @lc code=start
public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        (int, int)[] temp = new (int, int)[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            temp[i] = (arr[i], i);
        }

        Array.Sort(temp, (a, b) => a.Item1 - b.Item1);

        int rank = 1,
            j = 0,
            k = 0;
        while (j < temp.Length)
        {
            k = j;
            while (j < temp.Length &&
                temp[j].Item1 == temp[k].Item1)
            {
                arr[temp[j].Item2] = rank;
                j++;
            }
            rank++;
        }
        return arr;
    }
}
// @lc code=end

