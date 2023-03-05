
Console.Clear();
Console.Write("Наш массив: ");
string[] arrayA = new string[] { "123", "?", "Moscow", "56*@", "OMG", "Rus", ":-((", ":-0" };

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void Formation(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string numbers = arr[i];
        if (numbers.Length <= 3)
        {
            arr[i] = numbers;
    }
        else arr[i] = string.Empty;
    }
}
PrintArray(arrayA);
Formation(arrayA);
Console.Write("Новый массив: ");
PrintArray(arrayA);