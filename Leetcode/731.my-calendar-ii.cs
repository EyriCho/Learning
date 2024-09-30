/*
 * @lc app=leetcode id=731 lang=csharp
 *
 * [731] My Calendar II
 */

// @lc code=start
public class MyCalendarTwo {

    IList<(int, int)> calendar;
    IList<(int, int)> intersect;

    public MyCalendarTwo() {
        calendar = new List<(int, int)>();
        intersect = new List<(int, int)>();
    }
    
    public bool Book(int start, int end) {
        foreach ((int l, int r) in intersect)
        {
            if (start >= r || end <= l)
            {
                continue;
            }
            else
            {
                return false;
            }
        }

        foreach ((int l, int r) in calendar)
        {
            if (start >= r || end <= l)
            {
                continue;
            }
            else
            {
                intersect.Add((Math.Max(l, start), Math.Min(r, end)));
            }
        }

        calendar.Add((start, end));
        return true;
    }
}

/**
 * Your MyCalendarTwo object will be instantiated and called as such:
 * MyCalendarTwo obj = new MyCalendarTwo();
 * bool param_1 = obj.Book(start,end);
 */
// @lc code=end

