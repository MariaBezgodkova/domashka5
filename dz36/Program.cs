//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void FillArray(int[] arr) // заполняем массив
{
    int lenght = arr.Length;
    int index = 0;
    while (index < lenght)
    {
        arr[index] = new Random().Next(1, 10);
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
string NumberOddIndexes(int[] arr)// считаем кол-во четных чисел в массиве
{
    string result2 = "";
    int summ = 0;
    for (int index = 0; index < arr.Length; index++)
    {
        if (index % 2 == 1)
        {
            summ = summ + arr[index];
        }

    }
    result2 = result2 + summ;
    return result2;
}

int[] arr = new int[10]; // создаем новый массив, в котором будет 10 элементов
FillArray(arr);
string Print = PrintArray(arr);
string Print2 = NumberOddIndexes(arr);
Console.WriteLine(Print);
Console.WriteLine(Print2);
