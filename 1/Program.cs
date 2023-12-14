//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

for(int i = 0; ; i++)
{
    Console.WriteLine("Введите число");
    string stop = Console.ReadLine();

    if(stop == "q")
    {
        break;
    }
    int num = Convert.ToInt32(stop);
    int sum=0;
    int copyNum=num;

    while(copyNum>0)
    {
        sum = sum + copyNum%10;
        copyNum = copyNum/10;
    }
    
    if (sum%2 == 0)
    {
    break;
    }
}



