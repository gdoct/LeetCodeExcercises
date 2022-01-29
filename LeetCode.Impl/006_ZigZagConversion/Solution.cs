using System.Diagnostics;

namespace LeetCode.Impl.ZigZagConversion;

/*
 6. Zigzag Conversion
Medium

3265

7633

Add to List

Share
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

string convert(string s, int numRows);
 

Example 1:

Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"
Example 2:

Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:
P     I    N
A   L S  I G
Y A   H R
P     I
Example 3:

Input: s = "A", numRows = 1
Output: "A"
 

Constraints:

1 <= s.length <= 1000
s consists of English letters (lower-case and upper-case), ',' and '.'.
1 <= numRows <= 1000
 */
internal class Solution
{
    public string Convert(string s, int numRows)
    {
        int number_of_columns_for_step = 1 + Abs(0, numRows - 2);
        int numCols = CalculateWidth(s.Length, number_of_columns_for_step, numRows);

        char?[,] array = new char?[numCols, numRows];
        int letterIndex = 0;
        for (int col = 0; col < numCols; col++)
        {
            for (int row = 0; row < numRows; row++)
            {
                if (CanWrite(col, row, numRows, number_of_columns_for_step))
                {
                    if (letterIndex >= s.Length) break;
                    var letter = s[letterIndex];
                    array[col, row] = letter;
                    letterIndex++;
                }
            }
        }
        var sb = new System.Text.StringBuilder();
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                var val = array[col, row];
                if (val != null) sb.Append(val);
            }
        }
        return sb.ToString();
    }

    private static bool CanWrite(int col, int row, int height, int number_of_cells_for_step)
    {
        var additional_column_no = col % number_of_cells_for_step;
        /* bijv array 7x4
            [P _ _ I _ _ N]
            [A _ L S _ I G]
            [Y A _ H R _ _]
            [P _ _ I _ _ _]
        */
        // first column
        if (additional_column_no == 0) return true;

        // moving up
        if (row == (height - additional_column_no - 1)) return true;
        return false;
    }

    private static int CalculateWidth(int stringlength, int number_of_columns_for_step, int arrayheight)
    {
        // string is 14 chars, height = 4, one full cycle is 6 chars
        // remaining is then 2 chars
        int number_of_chars_for_step = arrayheight + Abs(0, arrayheight - 2);
        var remaining_characters = stringlength % number_of_chars_for_step;
        var columns_used = ((stringlength - remaining_characters) / number_of_chars_for_step) * number_of_columns_for_step;

        // now the remainder
        if (remaining_characters > 0)
        {
            columns_used += 1;
            remaining_characters -= arrayheight;
            if (remaining_characters > 0) columns_used += remaining_characters;
        }
        return columns_used;
    }

    private static int Abs(int max, int val)
    {
        if (max > val) return max;
        return val;
    }
}
