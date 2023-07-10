
void FillArray(string[] array)
{
    string[] new_array = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            new_array[i] = array[i];
        }
    }
    PrintArray(array);
    PrintArray(new_array);
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}

string[] array = {"Hello", "2", "world", ":-)"};

FillArray(array);
