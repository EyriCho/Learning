/*
 * @lc app=leetcode id=1046 lang=csharp
 *
 * [1046] Last Stone Weight
 */

// @lc code=start
public class Solution {
    public int LastStoneWeight(int[] stones) {
        var stack = new int[stones.Length + 1];
        var length = 0;
        void Add(int num)
        {
            int i = length++;
            stack[i] = num;
            
            while (i > 0)
            {
                int p = (i - 1) / 2;
                if (num <= stack[p])
                {
                    return;
                }
                
                stack[i] ^= stack[p];
                stack[p] ^= stack[i];
                stack[i] ^= stack[p];
                i = p;
            }
        }
        
        int Pop()
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
                
                if (stack[i] < stack[l] || 
                    (r < length && stack[i] < stack[r]))
                {
                    if (r >= length || stack[l] >= stack[r])
                    {
                        stack[i] ^= stack[l];
                        stack[l] ^= stack[i];
                        stack[i] ^= stack[l];
                        
                        i = l;
                    }
                    else
                    {
                        stack[i] ^= stack[r];
                        stack[r] ^= stack[i];
                        stack[i] ^= stack[r];
                        
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
        
        foreach (var stone in stones)
        {
            Add(stone);
        }
        
        while (length > 1)
        {
            int a = Pop(),
                b = Pop();
            
            int left = Math.Abs(a - b);
            if (left > 0)
            {
                Add(left);
            }
        }
        
        return length == 0 ? 0 : stack[0];
    }
}
// @lc code=end

