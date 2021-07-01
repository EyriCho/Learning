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
            se[i] = (speed[i], efficiency[i]);
        
        Array.Sort(se, (a, b) => b.Item2 - a.Item2);
        
        var spdStack = new int[k + 1];
        var length = 0;
        void Add(int num)
        {
            var i = length;
            spdStack[length++] = num;
            
            while (i > 0)
            {
                var p = (i - 1) / 2;
                if (spdStack[i] >= spdStack[p])
                    return;
                spdStack[i] ^= spdStack[p];
                spdStack[p] ^= spdStack[i];
                spdStack[i] ^= spdStack[p];
                i = p;
            }
        }
        
        int Pop()
        {
            var rst = spdStack[0];
            spdStack[0] = spdStack[--length];
            var i = 0;
            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;
                if (l >= length)
                    break;
                if (spdStack[i] > spdStack[l] || 
                    (r < length && spdStack[i] > spdStack[r]))
                {
                    if (r >= length || spdStack[l] <= spdStack[r])
                    {
                        spdStack[i] ^= spdStack[l];
                        spdStack[l] ^= spdStack[i];
                        spdStack[i] ^= spdStack[l];
                        i = l;
                    }
                    else
                    {
                        spdStack[i] ^= spdStack[r];
                        spdStack[r] ^= spdStack[i];
                        spdStack[i] ^= spdStack[r];
                        i = r;
                    }
                }
                else
                    break;
            }
            
            return rst;
        }
        
        long result = 0;
        long sum = 0;
        for (int i = 0; i < n; i++)
        {
            var (s, e) = se[i];
            if (length < k)
            {
                Add(s);
                sum += s;
            }
            else
            {
                if (s > spdStack[0])
                {                
                    sum -= Pop();
                    Add(s);
                    sum += s;
                }
            }
            
            result = Math.Max(result, sum * e);
        }
        
        return (int)(result % 1_000_000_007);
    }
}
// @lc code=end

