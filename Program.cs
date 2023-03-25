string[] str = new string[] { "hello", "2", "world", ":-)" };
Console.WriteLine(String.Join(", ", str));

/// <summary>
/// Метод, формирующий новый массив из строк, длина которых меньше или равна заданному значению 
/// </summary>
/// <param name="inputArray">Входящий массив</param>
/// <param name="findSize">Искомая длина строки</param>
/// <returns>Новый массив</returns>
string[] ShowLessOrEqual(string[] inputArray, int findSize)
{
    //Для начала нужно определить длину нового массива
    int size = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= findSize)
        {
            size++;
        }
    }
    //После того как длина найдена, переходим к формированию нового массива
    string[] result = new string[size];
    for (int m = 0; m < size; m++)
    {
        for (int j = 0; j < inputArray.Length; j++)
        {
            if (inputArray[j].Length <= findSize)
            {
                result[m] = inputArray[j];
                m++;
            }
        }
    }
    return result;
}
string[] newArray = ShowLessOrEqual(str, 3);
Console.WriteLine($"{String.Join(", ", newArray)}");