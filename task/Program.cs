using static System.Console;
Clear();
WriteLine("Введите размер массива: ");
int size = int.Parse(ReadLine()!);
string[] array = GetArray( new string[size]);
PrintArray(array);
int result = GetLenghtNewArray(array);
WriteLine();
WriteLine($"Количество элементоd массива с длиной меньше или равное трем - {result}");
string[] threeArray = GetLenghtThreeArray(result, array);
PrintArray(threeArray);








string[] GetArray( string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i ++)
    {
        WriteLine("Введите строку: ");
        stringArray[i] = Convert.ToString(ReadLine()!);
    }
    return stringArray;
}


void PrintArray(string[] MyArray)
{
    Write("[");
    for (int i = 0; i < MyArray.Length - 1; i++)
    {
        Write($"{MyArray[i]},");
    }
    Write($"{MyArray[MyArray.Length - 1]}]");
}

int GetLenghtNewArray(string[] inputArray)
{
    int count =0;
    for (int i =0; i < inputArray.Length; i ++)
    {
        if (inputArray[i].Length <= 3)
        {
            count ++;
        }
    }
    return count;
}

string[] GetLenghtThreeArray(int number, string[] newArray)
{
    string[] result = new string[number];
    int j = 0;
    for (int i = 0; i < newArray.Length; i++)
    {   
       if (newArray[i].Length <= 3)
        {
            result[j] = newArray[i];
            j ++;
        }             
    }
    return result;
}