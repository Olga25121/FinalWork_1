// Задача: Написать программу, которая 
// 1. из имеющегося массива строк 
// 2. формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
// string[] array1 = new string[5] { "Hi", "GB", "world", "2023", "!" };



string[] array1 = new string[5] { "Hi", "GB", "world", "2023", "!" };


string[] ArrayLessThenThreeElements(string[] arr1, int num)
{
    string[] array2 = new string[CountLessThree(arr1, num)];
    int count = 0;

    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= num)
        {
            array2[count] = arr1[i];
            count++;
        }
    }
    return array2;
}

int CountLessThree(string[] arr1, int num)
{
    int count = 0;

    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= num)
        {
            count++;
        }
    }

    return count;
}

string[] array2 = ArrayLessThenThreeElements(array1, 3);
Console.WriteLine($"[{string.Join(", ", array1)}] -> [{string.Join(", ", array2)}]");