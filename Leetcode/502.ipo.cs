/*
 * @lc app=leetcode id=502 lang=csharp
 *
 * [502] IPO
 */

// @lc code=start
public class Solution {
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
        var cp = new (int, int)[profits.Length];
        for (int i = 0; i < profits.Length; i++)
        {
            cp[i] = (capital[i], profits[i]);
        }
        Array.Sort(cp, (a, b) => a.Item1 - b.Item1);

        var array = new int[profits.Length];
        var length = 0;
        void Add(int num)
        {
            var i = length++;
            array[i] = num;
            while (i > 0)
            {
                var p = (i - 1) >> 1;
                if (array[i] > array[p])
                {
                    array[i] ^= array[p];
                    array[p] ^= array[i];
                    array[i] ^= array[p];
                }
                i = p;
            }
        }

        int Pop()
        {
            var rst = array[0];
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

                if (array[i] < array[l] ||
                    (r < length && array[i] < array[r]))
                {
                    if (r >= length || array[l] >= array[r])
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
            return rst;
        }

        int max = w;
        int j = 0;
        while (k-- > 0)
        {
            while (j < profits.Length && cp[j].Item1 <= max)
            {
                Add(cp[j].Item2);
                j++;
            }

            if (length <= 0)
            {
                break;
            }

            max += Pop();
        }

        return max;
    }
}
// @lc code=end

