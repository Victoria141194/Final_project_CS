// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

Console.Clear();

string[] array1 = new string[10] {"hello","2","world","my","list","for","who","computer","8765","of"};
string[] array2 = FillSecondArray(array1);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);

//............................METHODS....................................
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
}


string[] FillSecondArray(string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3) count++;
    }
    
    string[] array2 = new string[count];
    int indexOfArray2 = 0;
    
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[indexOfArray2] = array1[i];
            indexOfArray2++;
        }
    }
    return array2;
}