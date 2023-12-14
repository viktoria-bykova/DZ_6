// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
// a b c => “abcdef”
// d e f 

string GenerateStringFromArray(char [,] arr) {
    string resultString = "";
    for (int i=0; i < arr.GetLength(0); i++) {
        for (int j=0; j < arr.GetLength(1); j++) {
            resultString += arr[i,j];
        }
    }
    return resultString;
}

char[,] myAarray = new char[2,3] { {'a', 'b', 'c'},  {'d', 'e', 'f'} };
string resultString = GenerateStringFromArray(myAarray);
Console.WriteLine("Результирующая строка: " + resultString);
