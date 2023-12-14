// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// “Hello my world” => “world my Hello”

bool IsPalindrome(string source)
{
    if (source == null)
        return false;

    int start = 0;
    int end = source.Length - 1;

    while (start < end)
    {
        // Skip non-alphanumeric characters
        while (start < end && !Char.IsLetterOrDigit(source[start])) start++;
        while (start < end && !Char.IsLetterOrDigit(source[end])) end--;

        if (Char.ToLower(source[start]) != Char.ToLower(source[end]))
        {
            return false;
        }

        start++;
        end--;
    }

    return true;
}

string str1 = "aBcD1ef!-";
string str2 = "шалаш";
string str3 = "55655";

Console.WriteLine(str1 + " => " + (IsPalindrome(str1) == true ? "Да" : "Нет"));
Console.WriteLine(str2 + " => " + (IsPalindrome(str2) == true ? "Да" : "Нет"));
Console.WriteLine(str3 + " => " + (IsPalindrome(str3) == true ? "Да" : "Нет"));