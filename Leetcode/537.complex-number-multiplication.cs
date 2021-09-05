/*
 * @lc app=leetcode id=537 lang=csharp
 *
 * [537] Complex Number Multiplication
 */

// @lc code=start
public class Solution {
    public string ComplexNumberMultiply(string num1, string num2) {
        int real1 = 0, real2 = 0,
            imaginary1 = 0, imaginary2 = 0;
        
        var index = num1.IndexOf('+');
        real1 = int.Parse(num1[0..index]);
        imaginary1 = int.Parse(num1[(index + 1)..(num1.Length - 1)]);

        index = num2.IndexOf('+');
        real2 = int.Parse(num2[0..index]);
        imaginary2 = int.Parse(num2[(index + 1)..(num2.Length - 1)]);
        
        int real = real1 * real2 - imaginary1 * imaginary2,
            imaginary = real1 * imaginary2 + real2 * imaginary1;
        
        return $"{real}+{imaginary}i";
    }
}
// @lc code=end

