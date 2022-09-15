/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да  */


// задача 32


Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    Console.WriteLine(" ");
    return res;
}

int[] array = GetArray(4, -10, 10);

foreach (int el in array)
{
    Console.Write($"{el * -1} ");
}
Console.WriteLine(" ");





Console.Clear();
//метод - генерация нового массива
int[] GetArray(int size, int minValue, int maxValue)
{
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    Console.Write("]");
    return res;
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine();
//запрос числа для поиска
Console.WriteLine("Введите число для поиска в массиве: ");
int number = int.Parse(Console.ReadLine());

// булева переменная - присутствие / отсутствие в массиве
bool boolResult = ArraySearch(array, number); 

//вывод результатов в консоль
Console.WriteLine($"Входит ли число {number} в массив? -> {BoolToString(boolResult)}"); 

//метод поиска заданного числа в массиве
bool ArraySearch(int[] arrayToSearch, int numberToSearch)
{
    foreach(int arrayelement in arrayToSearch)
    {
        if (arrayelement == numberToSearch)
        {
            return true;
        }
    }
    return false;
}

//метод - вывод "да" при ист






Console.Clear();

Console.WriteLine("Вы участвуете в лотереи, введите число от 1 до 10, и попытайте удачу ");
int number = int.Parse(Console.ReadLine());

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    Console.WriteLine(" ");
    return res;
}

int[] array = GetArray(7, 1, 10);


int res = 0;
foreach (int el in array)
{
    if (number == el)
        res = 1;
}
if (res == 1)
{
    Console.WriteLine("YOU ARE WINNER");
}
else
{
    Console.WriteLine("Попытайте удачу еще раз, YOU ARE LOSSER");
}







//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int count = 0;
int[] array = GetArray(5, 10, 99);
array[2] = 123;
Console.Write("массив [");
for (int i = 0; i < array.Length; i++)
{
    if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}"); // \r\n
    if (array[i] >9 && array[i]<100)
    {
        count++;
    }
}
Console.WriteLine("] ");
Console.Write($"Количество элементов массива, значения которых лежат в отрезке [10,99] -> {count} ");



//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int[] GetProduct(int[] res)
{
    int lenArray = res.Length;
    int lenPartArray = 0;
    if (lenArray%2 == 0)  lenPartArray = lenArray / 2;
    else lenPartArray = lenArray / 2 + 1;
    int[] arrayProduct = new int[lenPartArray];
    for (int i = 0; i < lenPartArray; i++)
    {
        if (i == lenPartArray-1)arrayProduct[i] = res[i];
        else arrayProduct[i] = res[i] * res[lenArray - i - 1];
    }
    return arrayProduct;
}

void PrintArray(int[] res)
{
    int size = res.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{res[i]} ");
    }
    Console.WriteLine();
}

int[] array = GetArray(11, -10, 10);
PrintArray(array);
int[] arrayProduct = GetProduct(array);
PrintArray(arrayProduct);



