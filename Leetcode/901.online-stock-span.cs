/*
 * @lc app=leetcode id=901 lang=csharp
 *
 * [901] Online Stock Span
 */

// @lc code=start
public class StockSpanner {

    public StockSpanner() {
        stack = new Stack<(int, int)>();
        count = 0;
    }
    
    Stack<(int, int)> stack;
    int count;
    
    public int Next(int price) {
        count++;
        while (stack.Count > 0 && stack.Peek().Item1 <= price)
        {
            stack.Pop();
        }
        
        int result = stack.Count > 0 ? (count - stack.Peek().Item2) : count;
        
        stack.Push((price, count));
        return result;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */
// @lc code=end

