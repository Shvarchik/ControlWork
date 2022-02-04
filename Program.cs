// Из имеющегося массива строк сформировать массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// пример ["1234","-2","Kazan", ":)"] -> ["-2",":)"]


void PrintArray (string[] array)
{
    int length = array.Length;
    Console.Write("[");
    for (int i = 0; i < length - 1; i++)
        Console.Write($"'{array[i]}', ");
    Console.WriteLine($"'{array[length - 1]}']");
}

void CreateNewArray (string [] array, string [] newArray)
{
    int countNewArray = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            newArray[countNewArray] = array[i];
            countNewArray++;
        }
    }
} 
int CountNewArray (string [] array)
{
    int newCount = 0;               // счетчик элементов, удовлетворяющих условию
    for (int i=0; i < array.Length;i++)
    {
        if (array[i].Length <=3)
            newCount++;
    }
    return newCount;
} 

string[] stringArray = new string[] { "1234", "-2", "Kazan", ":)" };

DateTime dt = DateTime.Now;
string [] ResultArray = new string [CountNewArray(stringArray)];
CreateNewArray (stringArray,ResultArray);
Console.WriteLine ("Исходный массив:");
PrintArray (stringArray);
Console.WriteLine ("Массив результат:");
PrintArray (ResultArray);
System.Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);
