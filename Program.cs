// Из имеющегося массива строк сформировать массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// пример ["1234","-2","Kazan", ":)"] -> ["-2",":)"]


void PrintArray (string[] array, int length)
{
    Console.Write("[");
    for (int i = 0; i < length - 1; i++)
        Console.Write($"'{array[i]}', ");
    Console.WriteLine($"'{array[length - 1]}']");
}
int CreateNewArray (string [] array, string [] newArray)
{
    int newCount = 0;               // счетчик заполненных элементов нового массива
    for (int i=0;i<array.Length;i++)
    {
        if (array[i].Length <=3)
        {
            newArray[newCount] = array[i];
            newCount++;
        }
    }
    return newCount;
} 
string[] stringArray = new string[] { "1234", "-2", "Kazan", ":)" };

string [] ResultArray = new string [50];
int countResult = CreateNewArray (stringArray,ResultArray);

Console.WriteLine ("Исходный массив:");
PrintArray (stringArray,stringArray.Length);
Console.WriteLine ("Массив результат:");
PrintArray (ResultArray,countResult);
