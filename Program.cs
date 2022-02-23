// Из имеющегося массива строк сформировать массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// пример ["1234","-2","Kazan", ":)"] -> ["-2",":)"]

int CountNewArray(string[] array)
{
    int newCount = 0;               // счетчик элементов, удовлетворяющих условию
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newCount++;
    }
    return newCount;
}
string[] CreateNewArray(string[] array, int lengthNewArray)
{
    string[] newArray = new string[lengthNewArray];
    int countNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[countNewArray++] = array[i];
        }
    }
    return newArray;
}
void PrintArray(string[] array)
{
    int length = array.Length;
    Console.Write("[");
    if (length == 0)
        Console.Write(" ]");
    else
    {
        for (int i = 0; i < length - 1; i++)
            Console.Write($"'{array[i]}', ");
        Console.WriteLine($"'{array[length - 1]}']");
    }
}

string[] stringArray = new string[] { "1234", "Kazan", "qer", "oh:)" };
string[] ResultArray = CreateNewArray(stringArray, CountNewArray(stringArray));
Console.WriteLine("Исходный массив:");
PrintArray(stringArray);
Console.WriteLine("Массив результат:");
PrintArray(ResultArray);
