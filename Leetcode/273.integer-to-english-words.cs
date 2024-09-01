/*
 * @lc app=leetcode id=273 lang=csharp
 *
 * [273] Integer to English Words
 */

// @lc code=start
public class Solution {
    public string NumberToWords(int num) {
        if (num == 0)
        {
            return "Zero";
        }

        string[] belowTwenty = new string[] {
            "Zero", "One", "Two", "Three", "Four",
            "Five", "Six", "Seven", "Eight", "Nine",
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen",
            "Twenty",
        };

        string[] belowHundred = new string[] {
            "Zero", "Ten", "Twenty", "Thirty", "Forty",
            "Fifty", "Sixty", "Seventy", "Eighty", "Ninety",
        };

        string[] beyond = new string[] {
            "Zero", "Thousand", "Million", "Billion", "Trillion",
        };

        int thousandPoint = 0,
            left = 0,
            tens = 0,
            single = 0;
        List<string> list = new ();
        while (num > 0)
        {
            left = num % 1_000;
            if (left > 0 && thousandPoint > 0)
            {
                list.Add(beyond[thousandPoint]);
            }

            tens = left % 100;
            if (tens > 0 && tens <= 20)
            {
                list.Add(belowTwenty[tens]);
            }
            else if (tens > 20)
            {
                single = tens % 10;
                if (single > 0)
                {
                    list.Add(belowTwenty[tens % 10]);
                }
                list.Add(belowHundred[tens / 10]);
            }

            left /= 100;
            if (left > 0)
            {
                list.Add("Hundred");
                list.Add(belowTwenty[left]);
            }

            num /= 1_000;
            thousandPoint++;
        }

        list.Reverse();
        return string.Join(" ", list);
    }
}
// @lc code=end

