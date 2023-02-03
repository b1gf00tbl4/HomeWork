Console.Clear();
Console.WriteLine("Создать массив!!");
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 33);
Console.WriteLine($"Результат: [{string.Join(" , ", array)}]");