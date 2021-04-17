/*
 * @lc app=leetcode id=622 lang=csharp
 *
 * [622] Design Circular Queue
 */

// @lc code=start
public class MyCircularQueue {

    public MyCircularQueue(int k) {
        array = new int[k];
        front = 0;
        end = k - 1;
        isEmpty = true;
    }
    
    int[] array;
    int front;
    int end;
    bool isEmpty;
    
    public bool EnQueue(int value) {
        var i = end + 1;
        if (i == array.Length)
            i = 0;
        
        if (!isEmpty && front == i)
            return false;
        
        end = i;
        array[end] = value;
        isEmpty = false;
        return true;
    }
    
    public bool DeQueue() {
        if (isEmpty)
            return false;

        if (front == end)
            isEmpty = true;
        
        front++;
        if (front == array.Length)
            front = 0;
        
        
        return true;
    }
    
    public int Front() {
        if (isEmpty)
            return -1;
        
        return array[front];
    }
    
    public int Rear() {
        if (isEmpty)
            return -1;
        
        return array[end];
    }
    
    public bool IsEmpty() {
        return isEmpty;
    }
    
    public bool IsFull() {
        if (isEmpty)
            return false;

        var i = end + 1;
        if (i == array.Length)
            i = 0;
        
        if (front == i)
            return true;
        return false;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */
// @lc code=end

