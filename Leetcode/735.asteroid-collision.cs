/*
 * @lc app=leetcode id=735 lang=csharp
 *
 * [735] Asteroid Collision
 */

// @lc code=start
public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stack = new Stack<int>();

        for (int i = 0; i < asteroids.Length; i++)
        {
            var asteroid = asteroids[i];
            if (stack.Count == 0)
            {
                stack.Push(asteroid);
                continue;
            }

            if (asteroid < 0)
            {
                while (stack.Count > 0 && stack.Peek() > 0)
                {
                    var left = asteroid + stack.Peek();
                    if (left > 0)
                    {
                        asteroid = 0;
                        break;
                    }
                    else if (left < 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        asteroid = 0;
                        stack.Pop();
                        break;
                    }
                }
            }
            if (asteroid != 0)
            {
                stack.Push(asteroid);
            }                
        }

        var result = new int[stack.Count];
        for (int i = result.Length - 1; i > -1; i--)
        {
            result[i] = stack.Pop();
        }

        return result;
    }
}
// @lc code=end

