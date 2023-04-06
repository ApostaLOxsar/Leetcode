//Дана строка s, найдите длину самой длинной подстрока без повторяющихся символов.
using System;

string s = "aabaab!bb";

int result = LengthOfLongestSubstring(s);
Console.WriteLine(LengthOfLongestSubstring(s));

int LengthOfLongestSubstring(string s)
{
    string res = "";
    int lengString = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (res.Contains(s[i]))
        {
            if (lengString < res.Length) lengString = res.Length;
            res = res.Substring(res.LastIndexOf(s[i]) + 1) + s[i];
        }
        else res += s[i];

    }
    if (lengString < res.Length) return res.Length;
    else return lengString;
}