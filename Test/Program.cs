// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

Console.Clear();

string[] array1 = new string[10] {"hello","2","world","my","list","for","who","computer","8765","of"};
string[] array2 = FillSecondArray(array1);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
