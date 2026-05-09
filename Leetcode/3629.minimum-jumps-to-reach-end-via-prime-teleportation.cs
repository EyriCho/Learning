/*
 * @lc app=leetcode id=3629 lang=csharp
 *
 * [3629] Minimum Jumps to Reach End via Prime Teleportation
 */

// @lc code=start
public class Solution {
    public int MinJumps(int[] nums) {
        bool IsPrime(int num)
        {
            if (num == 1)
            {
                return false;
            }
            
            int max = (int)Math.Sqrt(num);
            for (int i = 2; i <= max; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        int max = 0;
        Dictionary<int, IList<int>> dict = new ();
        HashSet<int> primes = new ();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!primes.Contains(nums[i]) && IsPrime(nums[i]))
            {
                primes.Add(nums[i]);
            }

            if (!dict.TryGetValue(nums[i], out IList<int> list))
            {
                dict[nums[i]] = list = new List<int>();
            }

            list.Add(i);
            max = Math.Max(max, nums[i]);
        }

        bool[] visited = new bool[nums.Length];
        Queue<(int, int)> queue = new ();
        queue.Enqueue((0, 0));
        visited[0] = true;
        int idx = 0,
            jump = 0;
        while (queue.Count > 0)
        {
            (idx, jump) = queue.Dequeue();

            if (idx == nums.Length - 1)
            {
                return jump;
            }

            if (idx > 0 && !visited[idx - 1])
            {
                queue.Enqueue((idx - 1, jump + 1));
                visited[idx - 1] = true;
            }

            if (idx + 1 < nums.Length && !visited[idx + 1])
            {
                queue.Enqueue((idx + 1, jump + 1));
                visited[idx + 1] = true;
            }

            if (primes.Contains(nums[idx]))
            {
                for (int n = nums[idx]; n <= max; n += nums[idx])
                {
                    if (!dict.TryGetValue(n, out IList<int> list))
                    {
                        continue;
                    }

                    foreach (int next in list)
                    {
                        if (!visited[next])
                        {
                            queue.Enqueue((next, jump + 1));
                            visited[next] = true;
                        }
                    }
                }

                primes.Remove(nums[idx]);
            }
        }

        return nums.Length - 1;
    }
}
// @lc code=end

