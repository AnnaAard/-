//Написать программу, которая из имеющегося массива строк формирует массив,
// состоящий только из тех строк, что меньше или равны 3 символам
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма

Console.WriteLine("введите количество элементов массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
string [] array = new string[sizeArr];
string[] arrayString = UserFillArray(array);
PrintArray(arrayString);



string[] UserFillArray(string[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void PrintArray(string[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"| {array[i]} |");
}
Console.Write("]");
}

