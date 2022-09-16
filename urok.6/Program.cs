// zada4a 40

Console.Beep();
Console.Clear();
Console.Write($"Введите стороны a, b, c:");
string strNumber = Console.ReadLine();
string[] points = strNumber.Split(',');
int[] intP = new int[3];
int count = 0;

foreach (string el in points)
{
    intP[count] = int.Parse(el);
    count++;
}

if (Proverka(intP)) Console.WriteLine("Треугольник может существовать");
else Console.WriteLine("Треугольник НЕ может существовать");

bool Proverka(int[] intPoints)
{
    bool result = false;
    if (intPoints[0] < intPoints[1] + intPoints[2] && intPoints[1] < intPoints[2] + intPoints[0] && intPoints[2] < intPoints[0] + intPoints[1])
    {
        result = true;
    }
    return result;
}










char[] delimiterChar = { ' ', ',', '.', '(', ')', '[', ']', '/' };

double[] triangleSides = new double[3];
bool[] checkStrings = new bool[3];

do
{
    Console.WriteLine("Введите три числа: ");
    string[] threeNumbers = Console.ReadLine().Split(delimiterChar);
    //Console.WriteLine(", ");
    if (threeNumbers.Length < 3) { continue; };
    checkStrings[0] = double.TryParse(threeNumbers[0], out triangleSides[0]);
    checkStrings[1] = double.TryParse(threeNumbers[1], out triangleSides[1]);
    checkStrings[2] = double.TryParse(threeNumbers[2], out triangleSides[2]);
}
while (!checkStrings[0] || !checkStrings[1] || !checkStrings[2]);

Console.Write(CheckTriangle(triangleSides)? $"может существовать ": $"не может существовать");

bool CheckTriangle(double[] triangleArray)
{
    double a = triangleArray[0];
    double b = triangleArray[1];
    double c = triangleArray[2];

    if (a < b + c && b < a + c && c < a + b)
    { return true; }
    else
    { return false; }
}








// zada4a 42

Console.Clear();
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число:");
int b = int.Parse(Console.ReadLine());


static void Main(int num10, int hoh)
{
        int num2it = 0; // num2it - остаток после % деления из которого формируется число в 
                     //    двоичной системе исчисления
        int i = 0;
 
        int[] array = new int[hoh]; // массив с помощью которого двоичное число позже 
                                 //будет выведено с конца для правильного отображения 
 
        while (num10 >= 1)
        {
            num2it = num10 % 2;
            array[i] = num2it;
            i++;
 
            num10 = num10 / 2;
 
            Console.Write(num2it);
        };
 
        Console.WriteLine();
 
        for (i = (array.Length - 1); i >= 0; i--)
        {
            Console.Write($"{array[i]} ");
        }
 
        Console.WriteLine();
}

Main(a, b);







Console.Clear();
int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));
int[] copyArray = CopyArray(array);
Console.WriteLine(String.Join(" ", copyArray));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int[] CopyArray(int[] inputArray)
{
    int len = inputArray.Length;
    int[] copyArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        copyArray[i] = inputArray[i];
    }
    return copyArray;
}










Console.WriteLine("Введите число: ");
bool res = uint.TryParse(Console.ReadLine(), out uint num);
uint[] rem = Fibonacci(num);
Console.WriteLine(String.Join(" ", rem));

uint[] Fibonacci(uint N)
{
    uint[] fib = new uint[N];
    fib[0] = 0;
    fib[1] = 1;
    for (uint i = 2; i < N; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    return fib;
}
