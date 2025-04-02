/*
 * @lc app=leetcode id=2349 lang=csharp
 *
 * [2349] Design a Number Container System 
 */

// @lc code=start
public class NumberContainers {

    Dictionary<int, int> indexs;
    Dictionary<int, PriorityQueue<int, int>> numbers;

    public NumberContainers() {
        indexs = new ();
        numbers = new ();
    }
    
    public void Change(int index, int number) {
        indexs[index] = number;
        if (!numbers.TryGetValue(number, out PriorityQueue<int, int> queue))
        {
            numbers[number] = queue = new ();
        }
        queue.Enqueue(index, index);
    }
    
    public int Find(int number) {
        numbers.TryGetValue(number, out PriorityQueue<int, int> queue);
        if (queue == null)
        {
            return -1;
        }

        while (queue.Count > 0)
        {
            if (indexs[queue.Peek()] == number)
            {
                break;
            }
            queue.Dequeue();
        }

        return queue.Count == 0 ? -1 : queue.Peek();
    }
}

/**
 * Your NumberContainers object will be instantiated and called as such:
 * NumberContainers obj = new NumberContainers();
 * obj.Change(index,number);
 * int param_2 = obj.Find(number);
 */
// @lc code=end

