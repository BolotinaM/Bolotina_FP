// Условие задачи:
// Написать программу, которая из имеющегося массива строк, формирует массив из строк, 
// длина которых меньше или равна трем символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array1 = new string[5] {"cat", "1111", "fish", "20", "zeliboba", "-11"};
string[] array2 = new string[array1.Length];

void SecondMass(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintMass(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}