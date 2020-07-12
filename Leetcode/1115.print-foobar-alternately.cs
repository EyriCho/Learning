/*
 * @lc app=leetcode id=1115 lang=csharp
 *
 * [1115] Print FooBar Alternately
 */

// @lc code=start
using System.Threading;

public class FooBar {
    private int n;
    private static AutoResetEvent _fooEvent = new AutoResetEvent(false);
    private static AutoResetEvent _barEvent = new AutoResetEvent(false);

    public FooBar(int n) {
        this.n = n;
        _fooEvent.Set();
    }

    public void Foo(Action printFoo) {
        
        for (int i = 0; i < n; i++) {
            _fooEvent.WaitOne();
            
            // printFoo() outputs "foo". Do not change or remove this line.
            printFoo();
            
            _barEvent.Set();
        }
    }

    public void Bar(Action printBar) {
        
        for (int i = 0; i < n; i++) {
            _barEvent.WaitOne();
            
            // printBar() outputs "bar". Do not change or remove this line.
            printBar();

            _fooEvent.Set();
        }
    }
}
// @lc code=end

