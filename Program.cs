//Написать программу, которая из имеющегося массива строк формирует массив,
// состоящий только из тех строк, что меньше или равны 3 символам
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма

Console.WriteLine("введите количество элементов массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArr];
string[] arrayString = UserFillArray(array);
PrintArray(arrayString);
int countLessThree = Count(arrayString);
string[] newArray = NewArray(arrayString, countLessThree);
Console.WriteLine();
PrintArray(newArray);
Console.WriteLine($" => Найденных элементов {countLessThree}");




string[] UserFillArray(string[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write($" {array[i]},  ");
        else Console.Write($" {array[i]} ");
    }
    Console.Write("]");
}

int Count(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 0 && array[i].Length < 4) count++;
    }
    return count;
}

string[] NewArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length > 0 && array[j].Length < 4)
        {
            newArray[i] = array[j];
            i++;
        }
    }
    return newArray;

}