// Задача 000: Итоговая проверочная работа
// Программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// Примеры:
//
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
//
using static MyLibrary;
//
string End = "Y";

while (End != "N")
{

    int N = DisplayReplyInt("Введите целое число - число элементов массива");

    if (N < 1) Console.WriteLine("Число не может быть меньше 1");
    else
    {
        string[] ArrIn = CreateStringArray(N);

        if (FillArrayConsoleTextString(ArrIn))
        {
            Console.WriteLine('\n' + "Исходный массив:");
            PrintStringArray(ArrIn);

            string[] ArrOut = new string[CountLengthSubArray(ArrIn, 3)];

            BuildSubArray(ArrIn, 3, ArrOut);
            
            Console.WriteLine('\n' + "Сформированный массив:");
            PrintStringArray(ArrOut);

        }
        else Console.WriteLine('\n' + "Ввод исходного массива был прерван. Его придется ввести заново...");

    }

    End = DisplayReplyString("Продолжить обработку (Y/N");
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

}
string[] stringArray = { "Х", "О", "Р", "О", "Ш", "Е", "Г", "О", " ", "Д", "Н", "Я", "!", "0" };

HappyNewYear(stringArray);  //   вывод на консоль сообщения.