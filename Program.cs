/* Дополнительно 3:
4: Отсортировать в матрице столбцы по убыванию значений
элементов в первой строке. Использовать заполнение
случайными значениями.
3 -2 6 4    -2 3 4 6
8 1 12 2 -> 1 8 2 12
5 4 -8 0    4 5 0 -8
*/

int [,] RandomIntNumbersArray(int a, int b)
{
 int[,] Num = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
        Num [i,j] = new Random().Next(-9, 10); // Случайное целое целое число от -9 до 9 вкл-но.
        }   
    }
    return Num;
}

void Print2DimInit(int [,] aaa)
{
System.Console.WriteLine();
int x = aaa.GetLength(0);
int y = aaa.GetLength(1);
System.Console.WriteLine($"Создан массив случайных целых чисел размером {x} строк и {y} столбцов:");
System.Console.WriteLine();
for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
            System.Console.Write(aaa[i,j] + " ");
        System.Console.WriteLine("");
    }
System.Console.WriteLine();
System.Console.WriteLine();

}

void Print2DimDesc(int [,] aaa)
{
System.Console.WriteLine();
int x = aaa.GetLength(0);
int y = aaa.GetLength(1);
System.Console.WriteLine($"Столбцы массива отсортированы по убыванию элементов первой строки:");
System.Console.WriteLine();
for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
            System.Console.Write(aaa[i,j] + " ");
        System.Console.WriteLine("");
    }
System.Console.WriteLine();
System.Console.WriteLine();

}

void Print2DimAsc(int [,] aaa)
{
System.Console.WriteLine();
int x = aaa.GetLength(0);
int y = aaa.GetLength(1);
System.Console.WriteLine($"Столбцы массива отсортированы по возрастанию элементов первой строки:");
System.Console.WriteLine();
for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
            System.Console.Write(aaa[i,j] + " ");
        System.Console.WriteLine("");
    }
System.Console.WriteLine();
System.Console.WriteLine();

}

Console.WriteLine();
Console.Write("Введите количество строк массива случайных целых чисел: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите количество столбцов массива случайных целых чисел: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int [,] qqq = RandomIntNumbersArray(m,n);
Print2DimInit(qqq);
int [,] rrr = SortArray1stLineDesc(qqq);
int [,] fff = SortArray1stLineAsc(qqq);
Print2DimDesc(rrr);
Print2DimAsc(fff);


int [,] SortArray1stLineDesc(int [,] bbb)
{
int[,] ccc = new int[bbb.GetLength(0), bbb.GetLength(1)];
var resCols = bbb.Cast<int>().Take(bbb.GetLength(1)).Select((elem, index) => new { value = elem, Index = index }).OrderByDescending(elem => elem.value).ToArray();
int ind = 0;
    foreach (var column in resCols)
    {
        for (int j = 0; j < bbb.GetLength(0); j++)
        {
            ccc[j, ind] = bbb[j, column.Index];
        }
    ind++;
    }
return ccc;
}

int [,] SortArray1stLineAsc(int [,] bbb)
{
int[,] ccc = new int[bbb.GetLength(0), bbb.GetLength(1)];
var resCols = bbb.Cast<int>().Take(bbb.GetLength(1)).Select((elem, index) => new { value = elem, Index = index }).OrderBy(elem => elem.value).ToArray();
int ind = 0;
    foreach (var column in resCols)
    {
        for (int j = 0; j < bbb.GetLength(0); j++)
        {
            ccc[j, ind] = bbb[j, column.Index];
        }
    ind++;
    }
return ccc;
}