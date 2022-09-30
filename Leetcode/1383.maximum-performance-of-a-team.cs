/*
 * @lc app=leetcode id=1383 lang=csharp
 *
 * [1383] Maximum Performance of a Team
 */

// @lc code=start
public class Solution {
    public int MaxPerformance(int n, int[] speed, int[] efficiency, int k) {
        var se = new (int, int)[n];
        for (int i = 0; i < n; i++)
        {
            se[i] = (speed[i], efficiency[i]);
        }
        
        Array.Sort(se, (a, b) => b.Item2 - a.Item2);
        
        var array = new int[k + 1];
        var length = 0;
        
        void Add(int s)
        {
            int i = length++;
            array[i] = s;
            
            while (i > 0)
            {
                var p = (i - 1) >> 1;
                
                if (array[p] <= array[i])
                {
                    return;
                }
                
                array[p] ^= array[i];
                array[i] ^= array[p];
                array[p] ^= array[i];
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
        
        long result = 0;
        long sum = 0;
        
        foreach (var (s, e) in se)
        {
            if (length < k)
            {
                Add(s);
                sum += s;
            }
            else if (s > array[0])
            {
                sum -= Pop();
                Add(s);
                sum += s;
            }
            
            result = Math.Max(result, sum * e);
        }
        
        return (int)(result % 1_000_000_007);
    }
}
// @lc code=end

