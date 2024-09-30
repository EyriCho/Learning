/*
 * @lc app=leetcode id=1381 lang=csharp
 *
 * [1381] Design a Stack With Increment Operation
 */

// @lc code=start
public class CustomStack {

    int[] array;
    int count;

    public CustomStack(int maxSize) {
        array = new int[maxSize];
        count = 0;
    }
    
    public void Push(int x) {
        if (count == array.Length)
        {
            return;
        }
        array[count++] = x;
    }
    
    public int Pop() {
        if (count == 0)
        {
            return -1;
        }
        else
        {
            return array[--count];
        }
    }
    
    public void Increment(int k, int val) {
        if (k > count)
        {
            k = count;
        }

        for (int i = 0; i < k; i++)
        {
            array[i] += val;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */
// @lc code=end

