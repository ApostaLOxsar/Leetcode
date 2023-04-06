//Given an integer x, return true if x is a palindrome, and false otherwise.

int x = 1210;
Console.WriteLine(IsPalindrome(x));
bool IsPalindrome(int x)
{
    if (x < 0) return false;
    else if (x < 10) return true;
    else
    {
        string massiv = x.ToString();
        for (int i = 0; i < massiv.Length / 2; i++)
            if (massiv[i] != massiv[massiv.Length - 1 - i]) return false;
        return true;
    }
}