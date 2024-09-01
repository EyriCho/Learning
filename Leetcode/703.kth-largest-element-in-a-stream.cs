/*
 * @lc app=leetcode id=703 lang=csharp
 *
 * [703] Kth Largest Element in a Stream
 */

// @lc code=start
public class KthLargest {

    public KthLargest(int k, int[] nums) {
        this.k = k;
        stack = new int[k + 1];
        
        foreach (var num in nums)
        {
            Add(num);
        }
    }
    
    int[] stack;
    int length;
    int k;
    
    private void AddNum(int num)
    {
        int i = length++,
            p = 0;
        stack[i] = num;
        
        while (i > 0)
        {
            p = (i - 1) / 2;
            if (num >= stack[p])
            {
                break;
            }
            
            stack[i] = stack[p];
            i = p;
        }
        
        stack[i] = num;
    }
    
    private int Pop()
    {
        int result = stack[0];
        stack[0] = stack[--length];
        int i = 0,
            l = 0,
            r = 0;
        while (true)
        {
            l = i * 2 + 1;
            r = i * 2 + 2;
            
            if (l >= length ||
                (stack[i] <= stack[l] && (r >= length || stack[i] <= stack[r])))
            {
                break;
            }
            
            if (r >= length || stack[l] <= stack[r])
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
        return result;
    }
    
    public int Add(int val) {
        if (length < k)
        {
            AddNum(val);
        }
        else if (val > stack[0])
        {
            AddNum(val);
            Pop();
        }
        
        return stack[0];
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
// @lc code=end

