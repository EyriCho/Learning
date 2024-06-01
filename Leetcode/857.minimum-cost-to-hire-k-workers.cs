/*
 * @lc app=leetcode id=857 lang=csharp
 *
 * [857] Minimum Cost to Hire K Workers
 */

// @lc code=start
public class Solution {
    public double MincostToHireWorkers(int[] quality, int[] wage, int k) {
        (double, int)[] ratios = new (double, int)[wage.Length];
        for (int i = 0; i < wage.Length; i++)
        {
            ratios[i] = ((double)wage[i] / quality[i], quality[i]);
        }

        Array.Sort(ratios, (a, b) => a.Item1 == b.Item1 ?
            a.Item2.CompareTo(b.Item2) :
            a.Item1.CompareTo(b.Item1));

        int length = 0;
        int[] array = new int[k + 1];

        void Add(int q)
        {
            int i = length++,
                p = 0;
            array[i] = q;

            while (i > 0)
            {
                p = (i - 1) >> 1;
                if (array[i] < array[p])
                {
                    break;
                }

                array[i] ^= array[p];
                array[p] ^= array[i];
                array[i] ^= array[p];
                i = p;
            }
        }

        int Pop()
        {
            int rst = array[0];
            array[0] = array[--length];
            int i = 0,
                l = 0,
                r = 0;
            while (true)
            {
                l = i * 2 + 1;
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

        int totalQual = 0;
        double result = double.MaxValue;
        foreach (var (r, q) in ratios)
        {
            totalQual += q;
            Add(q);
            if (length > k)
            {
                totalQual -= Pop();
            }

            if (length == k)
            {
                result = Math.Min(result, r * totalQual);
            }
        }

        return result;
    }
}
// @lc code=end

