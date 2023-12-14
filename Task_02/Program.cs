// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// “aBcD1ef!-” => “abcd1ef!-” 

string ConvertToLower(string input)
{
    char[] characters = input.ToCharArray();
    for (int i = 0; i < characters.Length; i++)
    {
        if (characters[i] >= 'A' && characters[i] <= 'Z')
        {
            characters[i] = (char)(characters[i] + 32);
        }
    }
    return new string(characters);
}

string sourceString = "dOcdECVEsKLeGqaulimWzDlxflRoAgGb";
string resultString = ConvertToLower(sourceString);
Console.WriteLine("Результирующая строка: " + resultString);
