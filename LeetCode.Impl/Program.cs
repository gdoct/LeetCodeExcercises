// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var result = LongestPalindrome("kfdjhahkasdfggfdsasajhhhfdsjjdfkjd");
if (result != "asdfggfdsa")
{
    Console.WriteLine("error");
}
else
    Console.WriteLine("YES");

Console.ReadLine ();

static string LongestPalindrome(string s)
{
    string solution = string.Empty;
    for (int i = 0; i < s.Length; i++)
    {
        var p1 = PalindromeAt(s, i);
        var p2 = AltPalindromeAt(s, i);
        if (p1.Length > p2.Length )
        {
            if (p1.Length > solution.Length) solution = p1;
        }else
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