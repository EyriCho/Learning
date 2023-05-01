/*
 * @lc app=leetcode id=2336 lang=csharp
 *
 * [2336] Smallest Number in Infinite Set
 */

// @lc code=start
public class SmallestInfiniteSet {
    SortedSet<int> set;
    int current;

    public SmallestInfiniteSet() {
        set = new SortedSet<int>();
        current = 1;
    }
    
    public int PopSmallest() {
        if (set.Count > 0)
        {
            var num = set.First();
            set.Remove(num);
            return num;
        }
        else
        {
            return current++;
        }
    }
    
    public void AddBack(int num) {
        if (num >= current)
        {
            return;
        }

        set.Add(num);
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */
 
// @lc code=end

