/*
 * @lc app=leetcode id=1354 lang=csharp
 *
 * [1354] Construct Target Array With Multiple Sums
 */

// @lc code=start
public class Solution {
    public bool IsPossible(int[] target) {
        var array = new int[target.Length + 1];
        var length = 0;
        void Add(int num)
        {
            var i = length;
            array[length++] = num;
            while (i > 0)
            {
                int p = (i - 1) >> 1;
                
                if (array[p] >= array[i])
                {
                    return;
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
            
            var i = 0;
            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;
                
                if (l >= length)
                {
                    break;
                }
                
                if (array[l] > array[i] ||
                    (r < length && array[r] > array[i]))
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
        
        long sum = 0L;
        foreach (var t in target)
        {
            sum += t;
            if (t > 1)
            {
                Add(t);
            }
        }
        
        while (length > 0)
        {
            long max = Pop();
            sum -= max;
            if (sum >= max || sum == 0)
            {
                return false;
            }
            
            max %= sum;
            if (sum != 1 && max == 0)
            {
                return false;
            }
            sum += max;
            if (max > 1)
            {
                Add((int)max);
            }
        }
        
        return true;
    }
}
// @lc code=end

