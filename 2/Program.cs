//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер мaссива:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int count = 0;

CreateArray();
int[] CreateArray()
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
        System.Console.Write(array[i]+ " ");

        if(array[i] % 2 == 0)
        {
            count = count + 1;
        } 
    }
    return array;

}

Console.WriteLine();
Console.WriteLine(count);
