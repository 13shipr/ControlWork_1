// сформировать массив строк с длиной <= 3

string[] array = new string[7] { "cat", "12346", "comp", "да", ";--)", "123", "4567" };
string[] arr = new string[array.Length];

void ArrayCondition(string[] array, string[] arr)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayCondition(array, arr);
PrintArray(arr);