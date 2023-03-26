// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// Метод для печати одномерного массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}]\t");
    }
}

// Метод находит строки в массиве не больше заданного параметра и возвращает новый массив строк
string[] FilterArray(string[] array, int parameter)
{   
    string[] result = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= parameter)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = array[i];
        }
    }
    return result;    
}

// Создаём строковый массив и заполняем его данными
string[] strArray = new string[] {"Hi", "my", "name", "is", "Giovanni", "Giorgio", ",", "but", "everybody", "call", "me", "Giorgio"};
// Устанавливаем параметр на 3 символа
int maxLength = 3;
// Выводим оригинальный массив в консоль
Console.WriteLine("Оригинальный массив:");
PrintArray(strArray);
Console.WriteLine();
// Создаём строковый массив и заполняем его данными посредством метода FilterArray
string[] filteredArray = FilterArray(strArray, maxLength);
// Выводим результат в консоль
Console.WriteLine($"Отфильтрованный массив (строки длинной меньше либо равные значению {maxLength}):");
// Проверка на заполненность массива данными
if (filteredArray.Length != 0)
{
    PrintArray(filteredArray);
}
else
{
    Console.WriteLine("Массив пустой");
}