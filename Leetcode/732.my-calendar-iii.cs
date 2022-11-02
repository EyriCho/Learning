/*
 * @lc app=leetcode id=732 lang=csharp
 *
 * [732] My Calendar III
 */

// @lc code=start
public class MyCalendarThree {

    public MyCalendarThree() {
        queue = new SortedList<int, int>();
        max = 0;
    }
    
    SortedList<int, int> queue;
    int max;
    
    public int Book(int start, int end) {
        if (!queue.ContainsKey(start))
        {
            queue.Add(start, 0);
        }
        if (!queue.ContainsKey(end))
        {
            queue.Add(end, 0);
        }
        
        queue[start] += 1;
        queue[end] -= 1;
        
        var count = 0;
        foreach (var b in queue)
        {
            if (end < b.Key)
            {
                break;
            }
            
            count += b.Value;
            max = Math.Max(count, max);
        }
        
        return max;
    }
}

/**
 * Your MyCalendarThree object will be instantiated and called as such:
 * MyCalendarThree obj = new MyCalendarThree();
 * int param_1 = obj.Book(start,end);
 */
// @lc code=end

