/*
 * @lc app=leetcode id=2075 lang=csharp
 *
 * [2075] Decode the Slanted Ciphertext
 */

// @lc code=start
public class Solution {
    public string DecodeCiphertext(string encodedText, int rows) {
        if (string.IsNullOrEmpty(encodedText))
        {
            return string.Empty;
        }
        int width = encodedText.Length / rows;

        char[] array = new char[(width + width - rows + 1) * rows / 2];
        int length = 0;

        for (int s = 0; s < width; s++)
        {
            for (int i = 0; i < rows; i++)
            {
                if (s + i >= width)
                {
                    break;
                }
                array[length++] = encodedText[i * width + s + i];
            }
        }

        while (array[length - 1] == ' ')
        {
            length--;
        }

        return new string(array, 0, length);
    }
}
// @lc code=end

