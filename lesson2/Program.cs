/*Задачи (лекции)
Найти максимум из 9 чисел
int Max(int arg1,int arg2,int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 20;
int b1 = 5;
int c1 = 15550;
int a2 = 8;
int b2 = 10;
int c2 = 39;
int a3 = 66;
int b3 = 1000;
int c3 = 150;
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3));
Console.WriteLine(max);
*/

/*Задача 2. Есть массив array, в котором n элементов, требуется найти элемент массива, который будет равен find
int [] array = { 11,31,31,41,15,16,71,81,91 };
int n = array.Length;
int index = 0;
int find = 31;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index+1;
}
*/

//Задача 3 (лекции). Заполнить массив случайными числами.

/*void FillArray(int[] numbers )
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1,   20);
        index+=1;
    }
}  
void PrintArray(int[] collection)
{
    int lenght = collection.Length;
    int count = 0;
    while (count < lenght)
    {
        Console.Write(collection[count] + " " );
        count +=1;
    }
}     
int [] array = new int [20];
FillArray(array);
PrintArray(array);
/*
