/*
 * @lc app=leetcode id=295 lang=csharp
 *
 * [295] Find Median from Data Stream
 */

// @lc code=start
public class MedianFinder {

    /** initialize your data structure here. */
    public MedianFinder() {
        small = new MinStack();
        large = new MinStack();
    }
    
    MinStack small;
    MinStack large;
    
    public void AddNum(int num) {
        small.Add(-num);
        large.Add(-small.Pop());
       
        if (large.Count > small.Count)
        {
            small.Add(-large.Pop());
        }
    }
    
    public double FindMedian() {
        return small.Count > large.Count ? -small.Peek() : (large.Peek() - small.Peek()) * 0.5d;
    }
    
    internal class MinStack
    {
        private int length;
        private int capacity;
        private int[] array;
        
        internal int Count => length;
        
        internal MinStack()
        {
            array = new int[3];
            capacity = 2;
            length = 0;
        }
        
        internal void Add(int num)
        {
            int i = length;
            array[length++] = num;
            while (i > 0)
            {
                int p = (i - 1) / 2;
                if (array[i] >= array[p])
                    break;
                
                array[i] ^= array[p];
                array[p] ^= array[i];
                array[i] ^= array[p];
                i = p;
            }
            
            if (length == capacity)
            {
                var newArray = new int[capacity * 2 + 1];
                Array.Copy(array, newArray, length);
                array = newArray;
                capacity *= 2;
            }
        }
        
        internal int Pop()
        {
            var result = array[0];
            
            array[0] = array[--length];
            int i = 0;
            while (true)
            {
                int l = i * 2 + 1,
                    r = i * 2 + 2;
                
                if (l >= length)
                    break;
                
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
                    break;
            }
            
            return result;
        }
        
        internal int Peek()
        {
            return array[0];
        }
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */
// @lc code=end

