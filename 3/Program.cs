//Задача 3: Напишите программу, которая перевернёт 
//одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)


Console.WriteLine("Введите размер массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
CreateArray();
int[] CreateArray()
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i]= new Random().Next(0,101);  
        System.Console.Write(array[i]+ " ");
    }
    return array;
}
Console.WriteLine(); 
Array.Reverse(array);
foreach (var i in array)
{
    System.Console.Write("{0} ", i);
}


    


