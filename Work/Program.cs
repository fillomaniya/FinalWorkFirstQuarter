string[] DataArray = {"Hello", "2", "world", ":-)"};
string[] NewArray = new string[DataArray.Length];

FindResult(DataArray, NewArray);
PrintArray(NewArray);

void FindResult(string[] DataArray, string[] NewArray)
{
    int count = 0;
    for (int i = 0; i < DataArray.Length; i++)
    {
    if(DataArray[i].Length <= 3)
        {
        NewArray[count] = DataArray[i];
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
