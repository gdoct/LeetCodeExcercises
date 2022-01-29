namespace LeetCode.Impl.PalindromeNumber;
/*
9. Palindrome Number (easy)

***
Runtime: 36 ms, faster than 99.43% of C# online submissions for Palindrome Number.
***

Given an integer x, return true if x is palindrome integer.

An integer is a palindrome when it reads the same backward as forward.

For example, 121 is a palindrome while 123 is not.
 

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 

Constraints:

-231 <= x <= 231 - 1 
 */
internal class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x < 10) return true;
        var digits = SplitDigits(x).ToArray();
        var digitsLength = digits.Length;
        int length = digitsLength / 2 + 1;
        for (int i = 0; i < length; i++)
        {
            digitsLength--;
            if (digits[i] != digits[digitsLength]) return false;
        }
        return true;
    }

    private static IEnumerable<int> SplitDigits(int num)
    {
        while (num > 0)
        {
            var remainder = num % 10;
            yield return remainder;
            num -= remainder;
            num /= 10;
        }
    }
}
