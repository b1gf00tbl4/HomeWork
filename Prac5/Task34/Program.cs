Console.Clear();
void inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int CountEvenInArray(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
        if (element % 2 == 0)
            count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите количество элемнтов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {CountEvenInArray(array)}");