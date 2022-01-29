namespace LeetCode.Impl.LongestPalindrome;

/*
5. Longest Palindromic Substring (medium)

Given a string s, return the longest palindromic substring in s.

Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"
 

Constraints:

1 <= s.length <= 1000
s consist of only digits and English letters.
 */
internal class Solution
{
    public string LongestPalindrome(string s)
    {
        string solution = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            var p1 = PalindromeAt(s, i);
            var p2 = AltPalindromeAt(s, i);
            if (p1.Length > p2.Length)
            {
                if (p1.Length > solution.Length) solution = p1;
            }
            else
                if (p2.Length > solution.Length) solution = p2;
        }
        return solution;
    }

    static string AltPalindromeAt(string s, int i)
    {
        var len = s.Length;
        if ((i + 1) >= len) return string.Empty;
        if (s[i] != s[i + 1]) return string.Empty;
        var offset = 1;
        var palindrome = $"{s[i]}{s[i + 1]}";
        while (true)
        {
            var fwd = i + offset + 1;
            var bck = i - offset;
            if (fwd >= len || bck < 0) return palindrome;
            if (s[fwd] != s[bck]) return palindrome;
            palindrome = $"{s[fwd]}{palindrome}{s[fwd]}";
            offset++;
        }

    }

    static string PalindromeAt(string s, int i)
    {
        var offset = 1;
        var palindrome = s[i].ToString();
        var len = s.Length;
        while (true)
        {
            var fwd = i + offset;
            var bck = i - offset;
            if (fwd >= len || bck < 0) return palindrome;
            if (s[fwd] != s[bck]) return palindrome;
            palindrome = $"{s[fwd]}{palindrome}{s[fwd]}";
            offset++;

        }
    }
}