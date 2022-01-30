#define DUMP

namespace LeetCode.Impl.RegEx;

/*
10. Regular Expression Matching (hard)
https://leetcode.com/problems/regular-expression-matching/

This implementation beats 99.84 % of csharp submissions

Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:
'.' Matches any single character.​​​​
'*' Matches zero or more of the preceding element.
The matching should cover the entire input string (not partial).

 

Example 1:

Input: s = "aa", p = "a"
Output: false
Explanation: "a" does not match the entire string "aa".
Example 2:

Input: s = "aa", p = "a*"
Output: true
Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
Example 3:

Input: s = "ab", p = ".*"
Output: true
Explanation: ".*" means "zero or more (*) of any character (.)".
 

Constraints:

1 <= s.length <= 20
1 <= p.length <= 30
s contains only lowercase English letters.
p contains only lowercase English letters, '.', and '*'.
It is guaranteed for each appearance of the character '*', there will be a previous valid character to match.
 
 */
internal class Solution
{
    public bool IsMatch(string s, string pattern)
    {
        var searchspace = new bool?[s.Length, pattern.Length];
        return DepthFirstSearch(ref s, ref pattern, 0, 0, ref searchspace);
    }

    private static bool DepthFirstSearch(ref string text, ref string pattern, int depth, int breadth, ref bool?[,] searchspace)
    {
        if (breadth == pattern.Length)
        {
            return (depth == text.Length);
        }
        
        if (depth == text.Length)
        {
            var n = pattern.Length - 1;
            while (n >= breadth)
            {
                if (pattern[n] != '*') return false;
                n -= 2;
            }
            return true;
        }

        if (searchspace[depth, breadth] != null)
            return searchspace[depth, breadth] ?? false;

        var isMatch = (text[depth] == pattern[breadth] || pattern[breadth] == '.');
        if (breadth + 1 < pattern.Length && pattern[breadth + 1] == '*')
        {
            isMatch = (isMatch && DepthFirstSearch(ref text, ref pattern, depth + 1, breadth, ref searchspace))
                      || DepthFirstSearch(ref text, ref pattern, depth, breadth + 2, ref searchspace);
        }
        else
        {
            isMatch = isMatch && DepthFirstSearch(ref text, ref pattern, depth + 1, breadth + 1, ref searchspace);
        }
        searchspace[depth, breadth] = isMatch;
        return isMatch;
    }
}
