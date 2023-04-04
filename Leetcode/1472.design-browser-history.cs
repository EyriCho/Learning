/*
 * @lc app=leetcode id=1472 lang=csharp
 *
 * [1472] Design Browser History
 */

// @lc code=start
public class BrowserHistory {

    Stack<string> backStack;
    Stack<string> forwardStack;

    public BrowserHistory(string homepage) {
        backStack = new Stack<string>();
        forwardStack = new Stack<string>();
        backStack.Push(homepage);
    }
    
    public void Visit(string url) {
        backStack.Push(url);
        forwardStack.Clear();
    }
    
    public string Back(int steps) {
        while (steps-- > 0 && backStack.Count() > 1)
        {
            forwardStack.Push(backStack.Pop());
        }
        return backStack.Peek();
    }
    
    public string Forward(int steps) {
        while (steps-- > 0 && forwardStack.Count() > 0)
        {
            backStack.Push(forwardStack.Pop());
        }
        return backStack.Peek();
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */
// @lc code=end

