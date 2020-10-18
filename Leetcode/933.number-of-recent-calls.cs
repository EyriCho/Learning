/*
 * @lc app=leetcode id=933 lang=csharp
 *
 * [933] Number of Recent Calls
 */

// @lc code=start
public class RecentCounter {

    public RecentCounter() {
        last = 0;
        pings = new Queue<int>();
    }
    
    int last;
    Queue<int> pings;
    public int Ping(int t) {
        pings.Enqueue(t);
        
        int startPos = t - 3000 > 0 ? t - 3000 : 1;
        while (last < startPos)
            last = pings.Dequeue();
        
        return pings.Count + 1;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
// @lc code=end

