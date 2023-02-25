//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2




void FillArray(int[] arr) // заполняем массив
{
    int lenght = arr.Length;
    int index = 0;
    while (index < lenght)
    {
        arr[index] = new Random().Next(100, 999);
        index++;
    }

}

string PrintArray(int[] arr)  // вывод массива
{
    string result = "";
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write(arr[index] + ", ");
    }
    return result;
}


string NumberEvenNumbers(int[] arr)// считаем кол-во четных чисел в массиве
{
    string result2 = "";
    int Count = 0;
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] % 2 == 0)
        {
            Count++;
        }

    }
    result2 = result2 + Count;
    return result2;
}


int[] arr = new int[8]; // создаем новый массив, в котором будет 10 элементов
FillArray(arr);
string Print = PrintArray(arr);
string Print2 = NumberEvenNumbers(arr);
Console.WriteLine(Print);
Console.WriteLine(Print2 + "- четных чисел");
