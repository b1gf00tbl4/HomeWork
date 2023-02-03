Console.Clear();
void inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 101);
}

int SummaOddInArray(int[] array)
{
    int summa = 0;
    for (int i = 1; i < array.Length; i+=2)
        summa = summa = array[i];
    return summa;
}

Console.Clear();
Console.Write("Введите количество элемнтов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
inputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {SummaOddInArray(array)}");
// не понял, почему у меня не работает