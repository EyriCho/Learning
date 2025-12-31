/*
 * @lc app=leetcode id=3433 lang=csharp
 *
 * [3433] Count Mentions Per User
 */

// @lc code=start
public class Solution {
    public int[] CountMentions(int numberOfUsers, IList<IList<string>> events) {
        PriorityQueue<IList<string>, (int, string)> es = new (
            Comparer<(int time, string type)>.Create((a, b) => a.time.Equals(b.time) ?
                b.type.CompareTo(a.type) : 
                a.time.CompareTo(b.time)));

        int[] backOnlines = new int[numberOfUsers];

        int shoutAll = 0;
        int[] result = new int[numberOfUsers];

        foreach (IList<string> e in events)
        {
            es.Enqueue(e, (int.Parse(e[1]), e[0]));
        }

        IList<string> eve = null;
        int time = 0;
        while (es.Count > 0)
        {
            eve = es.Dequeue();
            time = int.Parse(eve[1]);

            switch(eve[0])
            {
                case "OFFLINE":
                    backOnlines[int.Parse(eve[2])] = time + 60;
                    break;
                case "MESSAGE":
                    if (eve[2] == "ALL")
                    {
                        shoutAll++;
                        break;
                    }
                    else if (eve[2] == "HERE")
                    {
                        for (int i = 0; i < numberOfUsers; i++)
                        {
                            if (backOnlines[i] <= time)
                            {
                                result[i]++;
                            }
                        }

                        break;
                    }

                    string[] ids = eve[2].Split(' ');
                    foreach (string id in ids)
                    {
                        result[int.Parse(id[2..])]++;
                    }

                    break;
                default:
                    break;
            }
        }

        for (int i = 0; i < numberOfUsers; i++)
        {
            result[i] += shoutAll;
        }
        return result;
    }
}
// @lc code=end

