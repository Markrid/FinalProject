Console.Write("Задайте объём массива строк для анализа (введите число): ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = GetArray(size);
Console.WriteLine($"Вы создали следующий массив строк: [{String.Join(";", array)}]");

string[] newArray = NewArray(array, 3);
Console.WriteLine($"Скорректированный массив строк равен: [{String.Join(";", newArray)}]");


/// <summary>
/// Метод для создания одномерного массива строк значения которого задаёт пользователь
/// </summary>
/// <param name="size">Задаём размер массива</param>
/// <returns>Одномерный массив строк</returns>
string[] GetArray(int size)
{
    Console.WriteLine("Задайте значение элементом массива через ENTER");
    string[] array = new string[size];
    for (int j = 0; j < size; j++)
    {
        array[j] = Convert.ToString(Console.ReadLine())!;
    }
    return array;
}

/// <summary>
/// Метод генерирует новый массив строк из элементов первичного массива, которые не прывашают определённый массив символов
/// </summary>
/// <param name="array">Массив для анализа</param>
/// <param name="count">Количество символов в одном элементе для нового массива</param>
/// <returns>Одномерный строковый массив из элементов по заданному размеру</returns>
string[] NewArray(string[] array, int count)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= count)
        {
            number++;
        }
    }

    string[] newArray = new string[number];
    int numberCell = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= count)
        {
            newArray[numberCell] = array[j];
            numberCell++;
        }
    }

    return newArray;
}

