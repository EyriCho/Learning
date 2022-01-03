/*
 * @lc app=leetcode id=210 lang=csharp
 *
 * [210] Course Schedule II
 */

// @lc code=start
public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var result = new int[numCourses];
        var prep = new int[numCourses];
        var next = new IList<int>[numCourses];
        var queue = new Queue<int>();
        
        for (int i = 0; i < numCourses; i++)
            next[i] = new List<int>();
        
        for (int i = 0; i < prerequisites.Length; i++)
        {
            prep[prerequisites[i][0]]++;
            next[prerequisites[i][1]].Add(prerequisites[i][0]);
        }
        
        for (int i = 0; i < numCourses; i++)
            if (prep[i] == 0)
                queue.Enqueue(i);
        
        int index = 0;
        while (queue.Count > 0)
        {
            var i = queue.Dequeue();
            result[index++] = i;
            
            foreach (var n in next[i])
            {
                prep[n]--;
                if (prep[n] == 0)
                    queue.Enqueue(n);
            }
        }
        
        if (index < numCourses)
            return new int[0];
        
        return result;
    }
}
// @lc code=end

