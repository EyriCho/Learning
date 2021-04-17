/*
 * @lc app=leetcode id=841 lang=csharp
 *
 * [841] Keys and Rooms
 */

// @lc code=start
public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        int count = rooms.Count;
        var visit = new bool[count];
        var queue = new Queue<int>();
        queue.Enqueue(0);
        while (queue.Count > 0)
        {
            var room = queue.Dequeue();
            if (!visit[room])
            {
                visit[room] = true;
                count--;
                foreach (var key in rooms[room])
                {
                    if (!visit[key])
                        queue.Enqueue(key);
                }
            }
        }
        return count == 0;
    }
}
// @lc code=end

