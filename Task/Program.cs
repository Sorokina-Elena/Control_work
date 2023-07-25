/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
using System.Text;
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
System.Console.InputEncoding = Encoding.GetEncoding(1251);

Console.WriteLine("Введите кол-во элементов массива");
int size = Convert.ToInt32(Console.ReadLine());

string [] myArray = new string[size];
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < size; i++)
    {
        myArray[i] = Console.ReadLine();
    }

Console.WriteLine("Вывод массива");
for (int i = 0; i < size; i++)
{
    if (myArray[i].Length <= 3)
        {
            Console.Write( $"{myArray[i]} "); 
        }
}

