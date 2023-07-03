/*
 * @lc app=leetcode id=2542 lang=csharp
 *
 * [2542] Maximum Subsequence Score
 */

// @lc code=start
public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) {
        var sorted = new (int, int)[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
        {
            sorted[i] = (nums1[i], nums2[i]);
        }

        Array.Sort(sorted, (a, b) => a.Item2 == b.Item2 ? b.Item1 - a.Item1 : b.Item2 - a.Item2);
        
        var array = new int[k + 1];
        int length = 0;

        void Add(int num)
        {
            array[length] = num;
            int i = length++;
            while (i > 0)
            {
                int p = (i - 1) >> 1;
                if (array[i] >= array[p])
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

                if (array[i] > array[l] ||
                    (r < length && array[i] > array[r]))
                {
                    if (r >= length || array[l] <= array[r])
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

        long result = 0L,
            sum = 0L;

        foreach (var (num1, num2) in sorted)
        {
            sum += num1;
            Add(num1);
            if (length > k)
            {
                sum -= Pop();
            }
            if (length == k)
            {
                result = Math.Max(result, sum * num2);
            }
        }

        return result;
    }
}
// @lc code=end

