/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 */

// @lc code=start
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        
        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }
        
        var stack = new (int, int)[k + 1];
        var length = 0;
        
        void Add(int num, int freq)
        {
            int i = length++;
            stack[i] = (num, freq);
            
            while (i > 0)
            {
                int p = (i - 1) / 2;
                
                if (stack[p].Item2 <= freq)
                {
                    break;
                }
                
                stack[i] = stack[p];
                i = p;
            }
            
            stack[i] = (num, freq);
        }
        
        (int, int) Pop()
        {
            var rst = stack[0];
            stack[0] = stack[--length];
            int i = 0;
            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;
                
                if (l >= length)
                {
                    break;
                }
                
                if (stack[i].Item2 > stack[l].Item2 ||
                    (r < length && stack[i].Item2 > stack[r].Item2))
                {
                    if (r >= length || stack[l].Item2 <= stack[r].Item2)
                    {
                        var temp = stack[i];
                        stack[i] = stack[l];
                        stack[l] = temp;
                        
                        i = l;
                    }
                    else
                    {
                        var temp = stack[i];
                        stack[i] = stack[r];
                        stack[r] = temp;
                        
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
        
        foreach (var kv in dict)
        {
            if (length < k || kv.Value > stack[0].Item2)
            {
                Add(kv.Key, kv.Value);

                if (length > k)
                {
                    Pop();
                }
            }
        }
        
        var result = new int[k];
        for (int i = 0; i < k; i++)
        {
            result[i] = stack[i].Item1;
        }
        return result;
    }
}
// @lc code=end

