//

Console.Write("Задайте объём массива строк для анализа (введите число): ");
int size = Convert.ToInt32(Console.ReadLine());


/// <summary>
/// Метод для создания одномерного массива строк значения которого задаёт пользователь
/// </summary>
/// <param name="size">Задаём размер массива</param>
/// <returns></returns>
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
string[] array = GetArray(2);

Console.WriteLine(String.Join(";", array));






