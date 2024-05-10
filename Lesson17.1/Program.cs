//Домашнее задание. Тема 17. Урок 1. Многомерный
//массив и массив массивов.

//int[][] arr = new int[][]
//{
//            new int[] { 1, 2, 3, 4, 5 },
//            new int[] { 6, 7, 8, 9, 10 }
//};


//Console.Write("Введите число 200: ");
//int num = int.Parse(Console.ReadLine());
//arr[1][3] = num;

//foreach (int[] inner in arr)
//{
//    Console.WriteLine(string.Join(", ", inner));
//}

//Домашнее задание. Тема 17. Урок 2. Многомерный
//массив и массив массивов.

int[][] arr = new int[][]
     {
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 6, 7, 8, 9, 10 },
            new int[] { 1, 3, 5, 7, 9 }
     };

Console.WriteLine("Значения массива:");
foreach (int[] inner in arr)
{
    Console.WriteLine(string.Join(", ", inner));
}

Console.WriteLine("\nСумма каждого одномерного массива:");
foreach (int[] inner in arr)
{
    int sum = 0;
    foreach (int num in inner)
    {
        sum += num;
    }
    Console.WriteLine(sum);
}

int totalSum = 0;
int totalCount = 0;
foreach (int[] inner in arr)
{
    foreach (int num in inner)
    {
        totalSum += num;
        totalCount++;
    }
}
double average = (double)totalSum / totalCount;
Console.WriteLine($"\nСреднее арифметическое всех значений массива: {average}");
