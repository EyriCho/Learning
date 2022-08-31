/*
 * @lc app=leetcode id=729 lang=csharp
 *
 * [729] My Calendar I
 */

// @lc code=start
public class MyCalendar {
    List<(int, int)> list;

    public MyCalendar() {
        list = new List<(int, int)>();
    }
    
    public bool Book(int start, int end) {
        int l = 0, r = list.Count,
            m = 0;
        while (l < r)
        {
            m = (l + r) / 2;
            if (list[m].Item1 == start)
            {
                break;
            }
            else if (list[m].Item1 > start)
            {
                r = m;
            }
            else
            {
                l = ++m;
            }
        }
        
        if (m > 0 && list[m - 1].Item2 > start)
        {
            return false;
        }
        if (m < list.Count && end > list[m].Item1)
        {
            return false;
        }
        
        list.Insert(m, (start, end));
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */
// @lc code=end

