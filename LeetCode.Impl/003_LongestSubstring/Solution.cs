
/*
 3. Longest Substring Without Repeating Characters (medium)

Given a string s, find the length of the longest substring without repeating characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
 */

namespace LeetCode.Impl.LongestSubstring;

internal class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var answerlength = 0;
        var answer = "";
        for (int y = 0; y < s.Length; y++)
        {
            var letter = s[y];
            if (!answer.Contains(letter))
            {
                answer += letter;
            }
            else
            {
                answer = "";
                // roll back y
                y = s.LastIndexOf(letter, y - 1);
            }
            if (answer.Length > answerlength)
            {
                answerlength = answer.Length;
            }
        }
        return answerlength;
    }
}
