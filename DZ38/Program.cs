//Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76

void FillArray(double[] arr) // заполняем массив
{
    int lenght = arr.Length;
    int index = 0;
    while (index < lenght)
    {
        arr[index] = new Random().NextDouble()*10 ;
        index++;
    }

}

string PrintArray(double[] arr)  // вывод массива
{
    string result = "";
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write(arr[index] + ", ");
    }
    return result;
}

double MinElement (double[] arr) // метод нахождения минимального элемента в массиве
{
    double result2 =0;
    double min = arr[0];
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index]<min) min = arr[index];
    }
    result2=result2+min;
return result2;
}
double MaxElement (double[] arr) // метод нахождения максимального элемента в массиве
{
    double result3 =0;
    double max = arr[0];
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index]>max) max = arr[index];
    }
    result3=result3+max;
return result3;
}

double[] arr = new double[10]; // создаем новый массив, в котором будет 10 элементов
FillArray(arr);
string Print = PrintArray(arr);
double min2 = MinElement (arr);
double max2 = MaxElement (arr);
double itog = max2-min2;

//string Print2 = NumberOddIndexes(arr);
Console.WriteLine(Print);
Console.WriteLine(min2 + "-минимальный элемент в массиве" );
Console.WriteLine(max2 + "-максимальный элемент в массиве" );
Console.WriteLine(itog + "- разница между ними" );