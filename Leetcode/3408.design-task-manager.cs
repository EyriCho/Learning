/*
 * @lc app=leetcode id=3408 lang=csharp
 *
 * [3408] Design Task Manager
 */

// @lc code=start
public class TaskManager {

    Dictionary<int, (int UserId, int Priority)> taskDict;
    PriorityQueue<(int Priority, int Id), (int Priority, int Id)> queue;

    public TaskManager(IList<IList<int>> tasks) {
        taskDict = new ();
        queue = new (Comparer<(int Priority, int Id)>.Create((a, b) => 
            b.Priority.Equals(a.Priority) ?
                b.Id.CompareTo(a.Id) :
                b.Priority.CompareTo(a.Priority)
        ));

        foreach (IList<int> t in tasks)
        {
            taskDict[t[1]] = (t[0], t[2]);
            queue.Enqueue((t[2], t[1]), (t[2], t[1]));
        }
    }
    
    public void Add(int userId, int taskId, int priority) {
        taskDict[taskId] = (userId, priority);
        queue.Enqueue((priority, taskId), (priority, taskId));
    }
    
    public void Edit(int taskId, int newPriority) {
        taskDict[taskId] = (taskDict[taskId].UserId, newPriority);
        queue.Enqueue((newPriority, taskId), (newPriority, taskId));
    }
    
    public void Rmv(int taskId) {
        taskDict.Remove(taskId);
    }
    
    public int ExecTop() {
        int priority = 0,
            taskId = 0;
        while (queue.Count > 0)
        {
            (priority, taskId) = queue.Dequeue();
            if (taskDict.TryGetValue(taskId, out (int UserId, int Priority) t) &&
                t.Priority == priority)
            {
                taskDict.Remove(taskId);
                return t.UserId;
            }
        }

        return -1;
    }
}

/**
 * Your TaskManager object will be instantiated and called as such:
 * TaskManager obj = new TaskManager(tasks);
 * obj.Add(userId,taskId,priority);
 * obj.Edit(taskId,newPriority);
 * obj.Rmv(taskId);
 * int param_4 = obj.ExecTop();
 */
 // @lc code=end

