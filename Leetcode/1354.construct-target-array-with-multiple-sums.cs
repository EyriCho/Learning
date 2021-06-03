/*
 * @lc app=leetcode id=1354 lang=csharp
 *
 * [1354] Construct Target Array With Multiple Sums
 */

// @lc code=start
public class Solution {
    public bool IsPossible(int[] target) {
        long total = 0;
        
        var array = new int[target.Length + 1];
        var length = 0;
        void Add(int num)
        {
            array[length++] = num;
            int i = length - 1;
            while (i > 0)
            {
                var parent = (i - 1) / 2;
                if (array[i] <= array[parent])
                    return;
                
                int temp = array[i];
                array[i] = array[parent];
                array[parent] = temp;
                i = parent;
            }
        }
        
        int Pop()
        {
            int result = array[0];
            array[0] = array[--length];
            int i = 0;
            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;
                
                if (l >= length)
                    break;
                
                if (array[l] > array[i] ||
                    (r < length && array[r] > array[i]))
                {
                    if (r >= length || array[l] >= array[r])
                    {
                        int temp = array[i];
                        array[i] = array[l];
                        array[l] = temp;
                        i = l;
                    }
                    else
                    {
                        int temp = array[i];
                        array[i] = array[r];
                        array[r] = temp;
                        i = r;
                    }
                }
                else
                    break;
            }
            
            return result;
        }
        
        foreach (var t in target)
        {    
            total += t;
            if (t > 1)
            Add(t);
        }
        
        while (length > 0)
        {
            long max = Pop();
            total -= max;
            if (total >= max || total == 0)
                return false;
            
            max %= total;
            total += max;
            if (max > 1)
                Add((int)max);
        }
        
        return true;
    }
}
// @lc code=end

