// Библиотека - долой колхоз!!!
//
public static class MyLibrary
{
    //   private const int V = 12;
    //
    //
    // Метод поиска минимального числа из двх целых чисел
    //
    public static int Min(int arg1, int arg2)
    {
        int result = arg1;
        if (arg2 < result) result = arg2;
        return result;
    }
    //
    // Метод поиска максимального числа из трех целых чисел
    //
    public static int Max(int arg1, int arg2, int arg3)
    {
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    }
    //
    // Метод создания одномерного целочисленного массива с заданным количеством элементов
    //
    public static int[] CreateIntArray(int count)
    {
        return new int[count];
    }
    //
    // Метод создания двумерного целочисленного массива с заданным количеством элементов
    //
    public static int[,] CreateIntArrayTwoDim(int rowcount, int colcount)
    {
        return new int[rowcount, colcount];
    }
    //
    // Метод создания одномерного массива с заданным количеством элементов
    // вещественными числами
    // 
    public static double[] CreateRealArray(int count)
    {
        return new double[count];
    }
    //
    // Метод создания двумерного массива с заданным количеством элементов
    // вещественными числами
    //
    public static double[,] CreateRealArrayTwoDim(int rowcount, int colcount)
    {
        return new double[rowcount, colcount];
    }
    //
    //
    // Метод заполнения одномерного целочисленного массива произвольными целыми числами
    // в заданном диапазоне значений 
    //
    public static void FillArray(int[] collection, int argmin, int argmax)
    {
        int length = collection.Length;

        int index = 0;

        while (index < length)
        {
            collection[index] = new Random().Next(argmin, argmax + 1);

            //      collection[index] = Random.Shared.Next(argmin, argmax);

            index++;

        }
    }
    //
    // Метод заполнения двумерного целочисленного массива произвольными числами в 
    // заданном диапазоне значений 
    //
    public static void FillArrayTwoDim(int[,] collection, int argmin, int argmax)
    {
        int rowcount = collection.GetLength(0);
        int colcount = collection.GetLength(1);

        int i = 0;
        int j = 0;

        while (i < rowcount)
        {
            while (j < colcount)
            {
                collection[i, j] = new Random().Next(argmin, argmax + 1);

                //      collection[index] = Random.Shared.Next(argmin, argmax);

                j++;

            }
            j = 0;
            i++;
        }

    }
    //
    // Метод заполнения одномерного массива произвольными вещественными числами
    // в заданном диапазоне значений 
    //
    public static void FillRealArray(double[] collection, int argmin, int argmax)
    {
        int length = collection.Length;

        int index = 0;

        while (index < length)
        {
            ///  collection[index] = new Random().Next(argmin, argmax);

            collection[index] = Convert.ToDouble(new Random().Next(argmin, argmax + 1) / 10.000);

            //      collection[index] = Random.Shared.Next(argmin, argmax);

            index++;

        }
    }
    //
    // Метод заполнения двумерного целочисленного массива произвольными числами в 
    // заданном диапазоне значений 
    //
    public static void FillRealArrayTwoDim(double[,] collection, int argmin, int argmax)
    {
        int rowcount = collection.GetLength(0);
        int colcount = collection.GetLength(1);

        int i = 0;
        int j = 0;

        while (i < rowcount)
        {
            while (j < colcount)
            {
                collection[i, j] = Convert.ToDouble(new Random().Next(argmin, argmax + 1) / 10.000);

                //      collection[index] = Random.Shared.Next(argmin, argmax);

                j++;

            }
            j = 0;
            i++;
        }

    }
    //
    //  Метод вывода двумерного массива целых чисел на печать 
    //
    public static void PrintIntArrayTwoDim(int[,] collection)
    {
        int rowcount = collection.GetLength(0);
        int colcount = collection.GetLength(1);

        int i = 0;
        int j = 0;

        while (i < rowcount)
        {
            while (j < colcount)
            {
                if (j == 0) Console.Write('\n' + $"{collection[i, 0],2}" + "; ");
                else Console.Write($"{collection[i, j],2}" + "; ");

                j++;

            }
            j = 0;
            i++;
        }

    }
    //
    //  Метод вывода двумерного массива вещественных чисел на печать
    //
    public static void PrintRealArrayTwoDim(double[,] collection)
    {
        int rowcount = collection.GetLength(0);
        int colcount = collection.GetLength(1);

        int i = 0;
        int j = 0;

        while (i < rowcount)
        {
            while (j < colcount)
            {
                if (j == 0) Console.Write('\n' + $"{collection[i, 0].ToString("F3"),2}" + "; ");
                else Console.Write($"{collection[i, j].ToString("F3"),2}" + "; ");

                j++;

            }
            j = 0;
            i++;
        }

    }
    //
    // Метод упорядочивания значений двумерного массива вещественных чисел  
    // в строках (по возрастанию или по убыванию) 
    //
    public static void SortArrayRows(double[,] collection, bool AscDesc)
    {
        int rowcount = collection.GetLength(0);
        int colcount = collection.GetLength(1);

        int i = 0;
        int j = 0;
        int l = 0;
        int k;
        double maxmin;

        for (i = 0; i < colcount; i++)
        {

            for (j = 1; j < rowcount; j++)
            {
                Console.WriteLine("i=" + $"{i}" + "j=" + $"{j}");

                maxmin = collection[i, j - 1];
                k = j;
                for (l = j; l <= rowcount; l++)
                {
                    if (maxmin > collection[i, l - 1])
                    {
                        maxmin = collection[i, l - 1];
                        k = l;
                    }

                }
                collection[i, k - 1] = collection[i, j - 1];
                collection[i, j - 1] = maxmin;


            }
        }
    }
    //Метод, сортирующий массив целых чисел (по возрастанию)
    public static void BubbleSort(double[] anArray)
    {

        //Основной цикл (количество повторений равно количеству элементов массива)
        for (int i = 0; i < anArray.Length; i++)
        {
            //Вложенный цикл (количество повторений, равно количеству элементов массива минус 1 и минус количество выполненных повторений основного цикла)
            for (int j = 0; j < anArray.Length - 1 - i; j++)
            {
                //Если элемент массива с индексом j больше следующего за ним элемента
                if (anArray[j] > anArray[j + 1])
                {
                    //Меняем местами элемент массива с индексом j и следующий за ним
                    double minmax = anArray[j];
                    anArray[j] = anArray[j + 1];
                    anArray[j + 1] = minmax;


                    //        Swap(ref anArray[j], ref anArray[j + 1]);
                }
            }
        }
    }
    // Метод, сортирующий массив целых чисел (по возрастанию)
    // На вход подается двумерный массив вещественных чисел,
    // элементы которого нужно отсортировать построчно по столбуам
    // второй параметр определяет порядок сортировки - по возрастанию (true) или по убыванию (false)
    public static void BubbleSortbyRowTwoDimDesc(double[,] anArray, bool desc)
    {

        int rowcount = anArray.GetLength(0);
        int colcount = anArray.GetLength(1);

        //Основной цикл (количество повторений равно количеству элементов массива в строке)
        for (int i = 0; i < rowcount; i++)
        {
            //Вложенный цикл (количество повторений, равно количеству элементов массива минус 1 и минус количество выполненных повторений основного цикла)
            // for (int j = 0; j < rowcount - 2 - i; j++)
            for (int j = 0; j < colcount; j++)
            {
                for (int k = j + 1; k < colcount; k++)
                {
                    // Сравниваем и при выполннии условия сравнения меняем местами значения элементов массива

                    if (desc)
                    {
                        if (anArray[i, j] > anArray[i, k])   // Сортировка по возрастанию
                        {                           //Меняем местами элемент массива с индексом j и следующий за ним
                            double minmax = anArray[i, j];
                            anArray[i, j] = anArray[i, k];
                            anArray[i, k] = minmax;
                        }
                    }
                    else                        // Сортировка по убыванию
                    {                           // Меняем местами элемент массива с индексом j и следующий за ним
                        if (anArray[i, j] < anArray[i, k])
                        {
                            double minmax = anArray[i, j];
                            anArray[i, j] = anArray[i, k];
                            anArray[i, k] = minmax;
                        }
                    }

                }

            }
        }

    }
    //
    //  Метод вывода одномерного массива на печать в столбик
    //
    public static void PrintArray(int[] arr)
    {
        int count = arr.Length;
        int position = 0;

        while (position < count)

        {
            Console.WriteLine(arr[position]);
            position++;
        }
    }
    //
    //  Метод вывода на печать одномерного массива целых числе в строки по N чисел,
    //  но не больше,чем по 10 чисел в строке
    //
    public static void PrintArrayInLine(int[] arr, int Linelength)
    {
        int Llength = 10;
        Console.WriteLine();

        if (Linelength < 10) Llength = Linelength;

        int count = arr.Length;
        int position = 0;
        int k = 1;

        while (position < count)
        {
            if (k < Llength)
            {
                if (position < count - 1) Console.Write($"{arr[position],3}" + ",");
                else Console.Write($"{arr[position],3}");
            }
            else
            {
                Console.WriteLine($"{arr[position],3}");
                k = 0;
            }
            k++;
            position++;
        }
        Console.WriteLine();
    }
    //
    //  Метод вывода на печать одномерного массива вещественных числе в строки по N чисел,
    //  но не больше,чем по 10 чисел в строке
    //
    public static void PrintRealArrayInLine(double[] arr, int Linelength)
    {
        int Llength = 10;
        Console.WriteLine();

        if (Linelength < 10) Llength = Linelength;

        int count = arr.Length;
        int position = 0;
        int k = 1;

        while (position < count)
        {
            if (k < Llength)
            {
                if (position < count - 1) Console.Write($"{arr[position].ToString("F3"),3}" + "; ");
                else Console.Write($"{arr[position].ToString("F3"),3}");
            }
            else
            {
                Console.WriteLine($"{arr[position].ToString("F3"),3}");
                k = 0;
            }
            k++;
            position++;
        }
        Console.WriteLine();
    }
    //
    //  Метод вывода на печать одномерного массива символов в строки по N элементов,
    //  но не больше,чем по 10 элементов в строке
    //
    public static void PrintStringArrayInLine(string[] arr, int Linelength)
    {
        int Llength = 10;
        Console.WriteLine();

        if (Linelength < 10) Llength = Linelength;

        int count = arr.Length;
        int position = 0;
        int k = 1;

        while (position < count)
        {
            if (k < Llength)
            {
                if (position < count - 1) Console.Write($"{arr[position] + "; "}");
                else Console.Write($"{arr[position]}");
            }
            else
            {
                // Console.WriteLine($"{arr[position].ToString("F3"),3}");
                Console.WriteLine($"{arr[position]}");
                k = 0;
            }
            k++;
            position++;
        }
        Console.WriteLine();
    }
    //
    //  Метод определения меньшего значения индекса элемента одномерного целочисленного массива, 
    //  значение которого равно заданному
    //
    public static int IndexOf(int[] collection, int finn)
    {
        int count = collection.Length;
        int index = 0;
        int position = -1;

        while (index < count)
        {
            if (collection[index] == finn)
            {
                position = index;
                break;
            }
            index++;
        }
        return position;
    }
    //
    //  Метод ввода с терминала строки символов
    //
    public static double DisplayReplyDouble(string PromptMessage)
    {
        double DoubleVal = 0;

        Console.WriteLine();
        Console.Write(PromptMessage + ": ");

        DoubleVal = Convert.ToDouble(Console.ReadLine());

        return DoubleVal;
    }
    //
    //  Метод ввода с терминала строки символов
    public static string DisplayReplyString(string PromptMessage)
    {
        string strVal = String.Empty;

        Console.WriteLine();
        Console.Write(PromptMessage + ": ");

        strVal = Console.ReadLine();

        return strVal;
    }
    //
    //
    //  Метод ввода с терминала целого числа (без предварительно очищения консоли)
    //
    public static int DisplayReplyIntSaveConsole(string PromptMessage)
    {
        int intVal = 0;


        Console.Write(PromptMessage + ": ");
        try
        {
            intVal = Convert.ToInt32(Console.ReadLine());
        }

        catch (FormatException)
        {
            // Console.WriteLine("Unable to convert '{0}' to a Double.", Console.ReadLine());
            Console.WriteLine("Допускаются только цифры, минимум одна - обязательна...", Console.ReadLine());
        }
        catch (OverflowException)
        {
            Console.WriteLine("'{0}' is outside the range of a Double.", Console.ReadLine());

        }

        return intVal;
    }
    //
    //
    //  Метод ввода с терминала целого числа (консоль предварительно очищается)
    //  Возвращает значение целого числа, введенного с консоли
    //
    public static int DisplayReplyInt(string PromptMessage)
    {
        int intVal = 0;


        Console.Clear();
        Console.Write(PromptMessage + ": ");
        try
        {
            intVal = Convert.ToInt32(Console.ReadLine());
        }

        catch (FormatException)
        {
            // Console.WriteLine("Unable to convert '{0}' to a Double.", Console.ReadLine());
            Console.WriteLine("Допускаются только цифры, минимум одна - обязательна...", Console.ReadLine());
        }
        catch (OverflowException)
        {
            Console.WriteLine("'{0}' is outside the range of a Double.", Console.ReadLine());

        }

        return intVal;
    }
    //
    //  Метод определяющий четность целого числа
    //
    public static bool EvenOdd(int numberA)
    {
        float b;
        bool result;

        b = numberA % 2;

        if (Math.Abs(b) < 1E-20) result = true;
        else result = false;

        return result;
    }
    //  For future use
    //  Метод определения количества и суммы цифр в целои числе
    //  на вход подается целое число
    //  возвращается количество цифр в этом числе и их сумма.

    public static int DigitsInNumber(int numberA, out int SumOfDigits)
    {

        int count = 0;

        int n = numberA;

        SumOfDigits = 0;

        if (numberA < 0) n = numberA * (-1);

        while (n > 0)
        {
            count = count + 1;

            SumOfDigits = SumOfDigits + n % 10;

            n = n / 10;
        }

        if (numberA == 0) count = 1;

        return count;

    }
    //  For Future use 
    //  Метод помещения цифр целого числа в массив
    //  Возвращает целочисленный массив, значения элементов которого в цифровом выражении
    //  представляют последовательность цифр, из которых составлено число, 
    //  начиная с младшего разряда (т.е. 1-й элемент массива (индекс 0) содержит самую правую цифру числа)
    //  Массив с числом элементов, равным количеству цифр в числе, 
    //  должен быть инициализирован до обращения к методу.
    //  На вход подается число, которое требуется разложить на цифры
    //
    public static void SplitNumberIntoDigitsRightToLeft(int numberA, int[] digArray)
    {


        int i = 0;

        int abnumberA = numberA;

        if (numberA < 0) abnumberA = numberA * (-1);


        while (i != numberA)

        {
            digArray[i] = abnumberA % 10;

            abnumberA = abnumberA / 10;

            i++;

        }

        if (numberA == 0) digArray[0] = 0;

        //   return digArray;
    }
    //
    //  Метод вывода заданной цифры из целого числа
    //  Возвращает цифру (в числовом выражении) в  PosLeftToRight-й слева позиции в числе numberA
    //  Если PosLeftToRight-й цифры в числе нет, возвращается значение -1.
    //
    public static int PosLeftToRight(int numberA, int PosLeftToRight)
    {
        int dLTR = -1;

        if (PosLeftToRight > 0)
        {


            int i = 0;

            int abnumberA = numberA;



            if (numberA < 0) abnumberA = numberA * (-1);


            while (abnumberA != 0)

            {

                abnumberA = abnumberA / 10;

                i++;

            }

            int totaldig = i; //  общее число цифр в числе

            if (numberA < 0) abnumberA = numberA * (-1);
            else abnumberA = numberA;

            if (PosLeftToRight > totaldig)  //  Проверка что номер позиции интересующей цифры        
                                            //  не превышает количества цифр в числе.
                                            // В противном случае вместо значения цифры возвращаем -1.
            {
                dLTR = -1; //  в числе нет указанной цифры - короткое число...
            }
            else
            {

                for (i = 1; i < (totaldig - PosLeftToRight + 1); i++)
                {
                    abnumberA = abnumberA / 10;
                }
                dLTR = abnumberA % 10;

            }
            if (abnumberA == 0) dLTR = 0;


        }
        else
        {
            dLTR = -1;  // номер позиции указан с ошибкой - ноль или отрицат число
        }
        return dLTR;
    }
    //  
    //  Метод возвращающий название дня недели или название - рабочий день или выходной...
    //  На вход подается порядковый номер дня в недели (1-7), параметр, определяющий что возвращать - 
    //  название дня недели и какой это день и параметр, определяющий на каком языке возвращать
    //  указанные значения

    public static string WeekDayName(int wkDaynumber, bool WeekDayName, int lang)
    {

        string wkday = String.Empty;


        string[] arrWeekDaysRus = { "не определен", "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
        string[] arrDaysRus = { "не определен", "рабочий", "рабочий", "рабочий", "рабочий", "рабочий", "выходной", "выходной" };

        string[] arrWeekDaysEng = { "Undefined", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        string[] arrDaysEng = { "undefined", "workday", "workday", "workday", "workday", "workday", "weekend", "weekend" };

        if (wkDaynumber < 1 | wkDaynumber > 7) wkDaynumber = 0;   //  проверка на ошибочное значение номера дня на входе

        if (lang == 0)    //  при увеличении числа языков заменим на case

        {
            if (WeekDayName) return arrWeekDaysRus[wkDaynumber];
            else return arrDaysRus[wkDaynumber];
        }
        else
        {
            if (WeekDayName) return arrWeekDaysEng[wkDaynumber];
            else return arrDaysEng[wkDaynumber];
        }

    }
    //  
    //  Метод построения инвертированного числа (т.е.числа, полученного из исходного
    //                  путем перстановки его цифр в обратном порядке)
    //
    public static int Inverse(int num)
    {
        int newnumber = 0;

        while (num > 0)
        { newnumber = newnumber * 10 + num % 10; num /= 10; }
        return newnumber;
    }
    //  
    //  Метод возведения целого числа в степень. Показатель степени - положительное целое число
    //
    public static bool MyPowInt(int A, int B, out int APowB)
    {

        APowB = 0;
        bool flag = false;

        if (B < 0)
        {
            Console.WriteLine("Метод не предназначен для возведения в отрицатеьную степень: " + $"{B,3}");
            return flag;
        }
        else
        {
            if (A == 0 && B == 0) Console.WriteLine("Операция возведения нуля в нулевую степень не определена.");
            else
            {
                if (B == 0) APowB = 1;
                else APowB = A;

                for (int i = 1; i < B; i++) APowB = APowB * A;

                flag = true;

            }
            return flag;

        }

    }
    // Метод вычисления десятичного представления целого числа, заданного в произвольной СС  (по основанию до 16)
    // Метод формирует представлеине числа в заданной СС и вычисляющий его десятичное представление.
    //
    // На вход подается числовой массив, элементами которого задается значение числа в заданной системе счисления,
    // снование системы счисления (до 16).
    // Выходными данными являются строка, содержащая 15-е или 16-е представление числа и
    // десятичное педставление этого числа.
    // использован метод из этой же библиотеки:
    // - MyPowInt() - возвращает значение целого числа возведенного в степень (степень - неотрицатеьное целое число).
    public static bool ConvertNumber(int[] collection, int SystemBase, out string BaseNumber, out int NumberDecimal)
    {

        bool flag = false;  // возвращаемый флажок успешного завершения работы метода (true/false)

        int length = collection.Length;

        int[] DecimalArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        string[] HexArray = { "не определено", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        BaseNumber = String.Empty;

        NumberDecimal = 0;

        if (length > 0)
        {
            int k = 0;

            string line = String.Empty;

            for (int i = 0; i < length; i++)
            {

                int j = MyLibrary.IndexOf(DecimalArray, collection[i]);

                line = line + HexArray[j];

                flag = MyLibrary.MyPowInt(SystemBase, length - 1 - i, out k);
                NumberDecimal = NumberDecimal + collection[i] * k;
                // Console.WriteLine("i=" + $"{i,3}" + "Numberdebug(i)= " + $"{NumberDecimal,3}" + "k= " + $"{k,3}");
                // Console.WriteLine("Line - " + $"{line}");
                flag = true;
                BaseNumber = line;
            }
        }
        else flag = false;    // Метод не отработал т.к. на вход был подан некорректно сфорированный массив 

        return flag;
    }
    public static void HappyNewYear(string[] stringArray)
    //
    //  Метод вывода на консоль поздравления с новым годом
    //  с интервалос в 0ю5 секунды побуквенно формируется строка
    //  С НОВЫМ ГОДОМ!  буквами разных цветов по подобранной гамме
    //  использован метод из этой же библиотеки:
    //  ChangeForegroundColor() - меняет по заданной гамме цвет шрифта на консоли
    //
    {

        // string[] stringArray = new string[25];
        // string[] stringArray = { "С", " ", "Н", "О", "В", "Ы", "М", " ", "Г", "О", "Д", "О", "М", "!", "0" };

        string strout = String.Empty;

        //     for future use
        //         case 0: return stringArray = { "С"," ","Н","О","В","Ы","М"," ","Г","О","Д","О","М","!","0" };
        //         case 1: return stringArray = { "H","A","P","P","Y"," ","N","E","W"," ","Y","E","A","R","!","0" };
        //         case 2: return sringArray = { "Ч","А","С","Т","И","Т","А"," ","Н","О","В","А"," ","Г","О","Д","И","Н","А","!","0"};
        //    

        // int[] ColorsArray = { 12, 10, 9, 11, 13, 14, 0, 15 };
        // ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

        int jFColor = 9;

        int k = 0;

        Console.WriteLine(">>>>>>>--------->>>>>>>>---------" + '\n');
        // Console.Clear();
        while (stringArray[k] != "0")
        {


            DateTime dateTime1 = DateTime.Now;
            DateTime dateTime2 = dateTime1;

            // var diffInSeconds = (dateTime1 - dateTime2).TotalSeconds;

            double diffInMilliSeconds = dateTime1.Subtract(dateTime2).TotalMilliseconds;
            while (diffInMilliSeconds < 500)
            {
                dateTime2 = DateTime.Now;
                diffInMilliSeconds = dateTime2.Subtract(dateTime1).TotalMilliseconds;
            }

            strout = strout + stringArray[k];

            // Console.ForegroundColor = ConsoleColor.White;

            //    if (jFColor == 9) jFColor = 14;
            //      if (jFColor == 14) jFColor = 12;
            //       if (jFColor == 12) jFColor = 11;
            //        if (jFColor == 11) jFColor = 10;
            //         if (jFColor == 10) jFColor = 13;
            //          if (jFColor == 13) jFColor = 9;



            // switch (jFColor)    // переключатель цветов в новогоднем поздравлении
            // {
            //     case 9:
            //         jFColor = 14;
            //         break;
            //     case 14:
            //         jFColor = 12;
            //         break;
            //     case 12:
            //         jFColor = 11;
            //         break;
            //     case 11:
            //         jFColor = 10;
            //         break;
            //     case 10:
            //         jFColor = 13;
            //         break;
            //     case 13:
            //         jFColor = 9;
            //         break;
            // }

            jFColor = ChangeForegroundColor(jFColor, strout, k);

            // Console.ForegroundColor = colors[jFColor];

            //Console.Write(strout[k]);
            // DateTime dateTime1 = new DateTime();
            k++;

        }
        Console.ResetColor();
        // Console.Clear();
        Console.WriteLine('\n');
    }
    //
    public static int ChangeForegroundColor(int InitialForegroundColor, string strout, int k)
    //
    //  Метод меняет по заданной гамме цвет шрифта на консоли в определенной последовательности
    //  и выводит на консоль в этом цвете k-й символ строки strout.
    //  На вход подаются значения:
    //  InitialForegroundColor - номер цвета в классе ConsoleColor;
    //  strout - строка, к которой должен быть добавлен символ;
    //  k - номер  печатемого сформированным цветом символа (в строке strout);
    //  Возвращает новое значение номера цвета в классе ConsoleColor.
    {
        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        int jFColor = InitialForegroundColor;

        switch (jFColor)    // переключатель цветов в новогоднем поздравлении
        {
            case 9:
                jFColor = 14;
                break;
            case 14:
                jFColor = 12;
                break;
            case 12:
                jFColor = 11;
                break;
            case 11:
                jFColor = 10;
                break;
            case 10:
                jFColor = 13;
                break;
            case 13:
                jFColor = 9;
                break;
        }
        Console.ForegroundColor = colors[jFColor];
        Console.Write(strout[k]);
        int jFcolorOut = jFColor;
        return jFcolorOut;
    }

    public static bool DataEntryForArrayDouble(double[] dArray, int iNCurrent, out int nFilled, bool debugFlag)
    //
    //  Метод возвращает массив введенных с консоли вещественных чисел
    //  На вход подается:
    //  а) целое число - длина массива;
    //  б) массив вещественных чисел, предназначенный для заполнения введенными с консоли числами.
    //
    //
    {
        int N = dArray.Length;
        ConsoleKeyInfo cki;
        bool flagOK = true;
        nFilled = iNCurrent;


        // Console.TreatControlCAsInput = true;   // Блокируем выход по CTRL+C, останутся только по Esc и Enter


        string[] ab = new string[150];
        int i = 0;

        while (i < N)      // Обнуляем заполняемый массив
        {
            dArray[i] = 0;
            i++;
        }
        i = 0;

        string StringFromConsole = string.Empty;           // Здесь формируем строку из значений символов, получаемых через элемент структуры Console.ReadKey();
        string ckiKeyToString = string.Empty;              // Строка для считывания кода при однократном обращении к Console.ReadKey();



        // Определяем значения массива ConsoleReadKeyValues как массив допустимых для ввода числовых данных кодов эл-та структуры, считываемой по Console.ReadKey()
        string[] ConsoleReadKeyValues = { "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "Oem2", "OemPeriod", "OemMinus", "Spacebar", "Enter", "Escape" };

        // int k = 100;

        Console.Clear();

        int origRow = Console.CursorTop;
        int origCol = Console.CursorLeft;
        // int colPos = origCol;
        Console.SetCursorPosition(origCol, origRow);
        Console.WriteLine("Вводите элементы массива (через пробел, лучше на латинской раскладке):");
        Console.WriteLine("Ввод чисел из сроки в массив - ENTER, отказ и повторный ввод - ESCAPE");

        // Clear the screen, then save the top and left coordinates.

        string ConsoleString = string.Empty;
        int kswitch = 1000;

        bool caseflag10 = true;      // флажки, используются для модификации ветвления - 
        bool caseflag11 = true;      //  блокируют повторный ввод клавиш пробел, точка, запятая, знак минус
        bool caseflag12 = true;     //  или комбинации их нежелательных последовательностей 
        bool caseflag13 = true;
        bool caseflag14 = true;

        do     // цикл опроса по Console.ReadKey();
        {
            Console.SetCursorPosition(origCol, origRow + 2);        // располагаем курсор в верхнем левом углу области


            cki = Console.ReadKey();

            ckiKeyToString = cki.Key.ToString();

            kswitch = 10000;    // если не является допустимым символом, то возвращается необрабатываемое в switch значение
                                //  таким образом ограничиваеим возможность ввода только цифрами, 
                                //  знаком минус, точкой и зпт, управление - Enter  и Escape

            for (int j = 0; j < 16; j++)        // формирую целочисленные значения для параметра переключателя
            {
                if (ckiKeyToString == ConsoleReadKeyValues[j])
                {
                    kswitch = j;
                    break;
                }

            }

            int kswitch1 = kswitch;
            if (kswitch < 10) kswitch1 = 0;


            // switch (kswitch)
            switch (kswitch1)

            {
                case 0:
                    caseflag10 = true;
                    caseflag11 = true;
                    caseflag12 = true;
                    caseflag13 = true;
                    caseflag14 = true;
                    StringFromConsole = kswitch.ToString();
                    ConsoleString = ConsoleString + StringFromConsole;
                    ab[i] = cki.Key.ToString();
                    i++;
                    break;
                case 10:
                    if (caseflag10)
                    {
                        caseflag10 = false;
                        caseflag14 = false;
                        StringFromConsole = ".";
                        ConsoleString = ConsoleString + StringFromConsole;
                        ab[i] = cki.Key.ToString();
                        i++;
                        break;
                    }
                    else break;
                case 11:
                    if (caseflag11)
                    {
                        caseflag11 = false;
                        caseflag14 = false;
                        StringFromConsole = ".";
                        ConsoleString = ConsoleString + StringFromConsole;
                        ab[i] = cki.Key.ToString();
                        i++;
                        break;
                    }
                    else break;
                case 12:
                    if (caseflag12)
                    {
                        caseflag12 = false;
                        caseflag14 = false;
                        StringFromConsole = "-";
                        ConsoleString = ConsoleString + StringFromConsole;
                        ab[i] = cki.Key.ToString();
                        i++;
                        break;
                    }
                    else break;
                case 13:
                    if (caseflag13)
                    {
                        caseflag13 = false;
                        caseflag14 = false;
                        StringFromConsole = " ";
                        ConsoleString = ConsoleString + StringFromConsole;
                        ab[i] = cki.Key.ToString();
                        i++;
                        break;
                    }
                    else break;
                case 14:
                    // StringFromConsole = "Enter";
                    if (caseflag14)
                    {
                        caseflag10 = true;
                        caseflag11 = true;
                        caseflag12 = true;
                        caseflag13 = true;
                        ab[i] = cki.Key.ToString();
                        i++;
                        break;
                    }
                    else break;
                case 15:
                    // StringFromConsole = "Escape";
                    caseflag10 = true;
                    caseflag11 = true;
                    caseflag12 = true;
                    caseflag13 = true;
                    caseflag14 = true;
                    ab[i] = cki.Key.ToString();
                    i++;
                    nFilled = -1;
                    break;
            }



            Console.Clear();
            Console.SetCursorPosition(0, 0);

            Console.Write(ConsoleString);



            if (cki.Key == ConsoleKey.Enter && caseflag14) break;

        } while (cki.Key != ConsoleKey.Escape);


        if (debugFlag) PrintStringArrayInLine(ab, 10);

        // Assign double  values to dArray elements from ConsoleString string

        i = 0;    //dArray index
        string[] subs = ConsoleString.Split(' ');
        if (nFilled != -1)
        {
            nFilled = 0;           // Счетчик числа заполненных в dArray значений - инициализация - обнуляем
        }
        else
        {
            Console.WriteLine("Вы прервали ввод, нажав Esc. Повторите последнюю транзакцию, пожалуйста.");
            return false;
        }
        foreach (string sub in subs)
        {

            try
            {
                dArray[i] = Convert.ToDouble(sub);
                nFilled++;      // Счетчик числа заполненных в dArray значений - добавляем 1 при заполнении очередного значения
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", sub);
                flagOK = false;
                break;
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", sub);
                flagOK = false;
                break;
            }
            if (i < N - 1) i++;    //  движемся по формируемому массиву значений
            else break;     //  до достижения его границы, что сверху границы длины массива остаются неприсвоенным
        }
        return flagOK;

    }
    public static bool FillArrayConsoleDouble(double[] MyArray, bool debugFlag)
    //
    // Метод заполнения массива вещественными числами с консоли
    // На вход полается массив вещественных чисел, который нужно заполнить, и значение флага выполнения в отладочном режиме
    // (в отладочном режиме  выдаются на консоль содержание рабочих массивов)
    // Возвращается заполненный значениями массив и булевское значение успешного (неуспешного) 
    // завершения работы метода
    //
    {
        int N = MyArray.Length;

        int M = 0;     // Счетчик заполненных элементов массива MyArray


        while (M < N)
        {
            int i = N - M;
            double[] dArray = MyLibrary.CreateRealArray(i);

            if (MyLibrary.DataEntryForArrayDouble(dArray, M, out int nassigned, false))
            {
                if (nassigned == -1)
                {
                    return false;
                }
                for (int j = 0; j < MyLibrary.Min(i, nassigned); j++)  //  В MyArray заносятся только первые N значений (в соответствии с его длиной)
                {
                    MyArray[M + j] = dArray[j];     //  Дописываем в массив MyArray с которым обращались из основной программы
                }

                M = M + nassigned;     //  обновляем количество заполненных элементов массива MyArray
            }
            else
            {
                Console.WriteLine("При вводе произошла ошибка. Повторите последнюю транзакцию, пожалуйста.");

                // PrintRealArrwithHeader("Распечатываем рабочий массив (отладка)", dArray,10);
                // PrintRealArrwithHeader("Распечатываем возвращаемый массив (отладка)", MyArray,10);


            }
            if (debugFlag)
            {
                PrintRealArrwithHeader("Распечатываем рабочий массив (отладка)", dArray, 10);
                PrintRealArrwithHeader("Распечатываем возвращаемый массив (отладка)", MyArray, 10);
            }
        }

        return true;
    }
    //
    //  Метод вывода на печать одномерного массива вещественных числе в строки по N чисел,
    //  но не больше,чем по 10 чисел в строке, с печатью заголовка перед выводом массива
    //
    public static void PrintRealArrwithHeader(string header, double[] MyArray, int ElementsInLine)
    {
        int elinline = 10;
        if (ElementsInLine <= 0) elinline = 10;
        else elinline = ElementsInLine;

        Console.WriteLine(header);
        MyLibrary.PrintRealArrayInLine(MyArray, elinline);     //  вывод массива на консоль не более 10 элементов в строку
    }
    //        
    // Метод рекурсивного составления строки из значений натуральных чисел в интервале от n до 1
    // На вход подается натуральное число и - границы интервала суммируемых чисел
    // Возвращается символьная строка, составленная из значений натуральных чисел в диапазоне от n до 1, 
    // разделенных пробелои и запятой, подготовленная к выводу на консоль
    //

    public static string NatRecurse(int n)
    {
        if (n == 1)
            return "1";
        else
            return n + ", " + NatRecurse(n - 1);
    }
    //        
    // Метод рекурсивного вычисления суммы натуральных чисел в заданном интервале их значений - от m до n
    // На вход подаются два натуральных числа (m и n) - границы интервалаа суммируемых чисел
    // Возвращается натуральное число - сумма чисел в интервале от m до n
    //
    public static int NatSumFromTo(int m, int n)
    {
        if (n == m)
            return m;
        return n + NatSumFromTo(m, n - 1);
    }
    //
    // Метод вычисления функции Аккермана
    // Возвращает значение функции Аккермана для двух неотрицательных целых чисел
    // На вход подаются два целых числа - n и m
    // На выходе возвращается неотрицательное целое число, рассчитанное по формулам, описывающим функцию
    // При больших значениях n и m может возникнуть переполнение стека
    //
    public static int Akm(int n, int m)
    {
        if (n == 0)
            return m + 1;
        else
          if ((n != 0) && (m == 0))
            return Akm(n - 1, 1);
        else
            return Akm(n - 1, Akm(n, m - 1));
    }
    //
    // Метод вывода на консоль содержимого массива строк
    // На вход полается массив, элементами которых являются символьные строки
    // Элементы массива выводятся на вонсоль в строку в приведенном в качестве примера выполнения задания формате
    // (написан специально под данную задачу)
    //
    public static void PrintStringArray(string[] array)
    {
        int k = array.Length;
        Console.Write('\n' + "[");
        for (int i = 0; i < k; i++)
        {
            if (i == k - 1) Console.WriteLine($"\"{array[i]}\"]" + '\n');
            else Console.Write($"\"{array[i]}\",");
        }
    }
    //
    // Метод копирования элементов массива символьных строк
    // длина которых не превышает заданную.
    // На вход подается исходный массив, минимальная длина строк,
    // копируемых в выходной массив и инициализированный массив нужной длины занесения в него 
    // значений строк, удовлетворяющих требованию по длине (не превышающих заданную) 
    // На выходе получаем сформированный массив
    //
    public static void BuildSubArray(string[] ArrIn, int maxLineLength, string[] ArrOut)
    {
        int k = ArrIn.Length;
        int j = 0;
        for (int i = 0; i < k; i++)
        {
            if (ArrIn[i].Length <= maxLineLength)
            {
                ArrOut[j] = ArrIn[i];
                j++;
            }
        }
    }
    // Метод подсчета количества элементов массива символьных строк,
    // длина которых не превышающей заданную
    // На вход полается исходный массив и максимально допустимая длина строки,
    // копируемых в выходной массив
    //
    public static int CountLengthSubArray(string[] ArrIn, int minLineLength)
    {
        int k = 0;
        for (int i = 0; i < ArrIn.Length; i++)
        {
            if (ArrIn[i].Length <= minLineLength) k++;
        }
        return k;
    }
    public static bool DataEntryForArrayString(string[] dArray, int iNCurrent, out int nFilled, bool debugFlag)
    //
    //  Метод возвращает массив введенных с консоли вещественных чисел
    //  На вход подается:
    //  а) целое число - длина массива;
    //  б) массив символьных строк, предназначенный для заполнения введенными с консоли числами.
    //  МЕТОД В СТАДИИ ОТДЛАДКИ (ПОКА НЕ ИСПОЛЬЗУЕТСЯ)!!!!!!!!
    //
    {
        int N = dArray.Length;
        ConsoleKeyInfo cki;
        bool flagOK = true;
        nFilled = iNCurrent;


        // Console.TreatControlCAsInput = true;   // Блокируем выход по CTRL+C, останутся только по Esc и Enter


        string[] ab = new string[200];
        int i = 0;

        while (i < N)      // Обнуляем заполняемый массив
        {
            dArray[i] = String.Empty;
            i++;
        }
        i = 0;

        string StringFromConsole = string.Empty;           // Здесь формируем строку из значений символов, получаемых через элемент структуры Console.ReadKey();
        string ckiKeyToString = string.Empty;              // Строка для считывания кода при однократном обращении к Console.ReadKey();



        // Определяем значения массива ConsoleReadKeyValues как массив допустимых для ввода числовых данных кодов эл-та структуры, считываемой по Console.ReadKey()
        // string[] ConsoleReadKeyValues = { "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "Oem2", "OemPeriod", "OemMinus", "Spacebar", "Enter", "Escape" };
        string[] ConsoleReadKeyValues = { "Spacebar", "Enter", "Escape" };

        // int k = 100;

        Console.Clear();

        int origRow = Console.CursorTop;
        int origCol = Console.CursorLeft;
        // int colPos = origCol;
        Console.SetCursorPosition(origCol, origRow);
        Console.WriteLine("Вводите элементы массива (через пробел, без кавычек):");
        Console.WriteLine("Ввод символьных строк в массив - ENTER, отказ и повторный ввод - ESCAPE");

        // Clear the screen, then save the top and left coordinates.

        string ConsoleString = string.Empty;
        int kswitch = 1000;

        // bool caseflag10 = true;      // флажки, используются для модификации ветвления - 
        // bool caseflag11 = true;      //  блокируют повторный ввод клавиш пробел, точка, запятая, знак минус
        // bool caseflag12 = true;     //  или комбинации их нежелательных последовательностей 
        // bool caseflag13 = true;
        bool caseflag14 = true;

        do     // цикл опроса по Console.ReadKey();
        {
            Console.SetCursorPosition(origCol, origRow + 2);        // располагаем курсор в верхнем левом углу области


            cki = Console.ReadKey();

            ckiKeyToString = cki.Key.ToString();

            kswitch = 10000;    // если не является допустимым символом, то возвращается необрабатываемое в switch значение
                                //  таким образом ограничиваеим возможность ввода только цифрами, 
                                //  знаком минус, точкой и зпт, управление - Enter  и Escape

            for (int j = 0; j < 3; j++)        // формирую целочисленные значения для параметра переключателя
            {
                if (ckiKeyToString == ConsoleReadKeyValues[j])
                {
                    kswitch = j;
                    break;
                }

            }

            int kswitch1 = kswitch;
            // if (kswitch < 10) kswitch1 = 0;


            // switch (kswitch)
            switch (kswitch1)

            {
                case 10000:
                    // caseflag10 = true;
                    // caseflag11 = true;
                    // caseflag12 = true;
                    // caseflag13 = true;
                    caseflag14 = true;
                    StringFromConsole = kswitch.ToString();
                    ConsoleString = ConsoleString + cki.Key.ToString();
                    // ConsoleString = ConsoleString + StringFromConsole;
                    ab[i] = cki.Key.ToString();
                    i++;
                    break;
                // case 10:
                //     if (caseflag10)
                //     {
                //         caseflag10 = false;
                //         caseflag14 = false;
                //         StringFromConsole = ".";
                //         ConsoleString = ConsoleString + StringFromConsole;
                //         ab[i] = cki.Key.ToString();
                //         i++;
                //         break;
                //     }
                //     else break;
                // case 11:
                //     if (caseflag11)
                //     {
                //         caseflag11 = false;
                //         caseflag14 = false;
                //         StringFromConsole = ".";
                //         ConsoleString = ConsoleString + StringFromConsole;
                //         ab[i] = cki.Key.ToString();
                //         i++;
                //         break;
                //     }
                //     else break;
                // case 12:
                //     if (caseflag12)
                //     {
                //         caseflag12 = false;
                //         caseflag14 = false;
                //         StringFromConsole = "-";
                //         ConsoleString = ConsoleString + StringFromConsole;
                //         ab[i] = cki.Key.ToString();
                //         i++;
                //         break;
                //     }
                //     else break;
                // case 13:
                //     if (caseflag13)
                //     {
                //         caseflag13 = false;
                //         caseflag14 = false;
                //         StringFromConsole = " ";
                //         ConsoleString = ConsoleString + StringFromConsole;
                //         ab[i] = cki.Key.ToString();
                //         i++;
                //         break;
                //     }
                //     else break;
                case 14:
                    // StringFromConsole = "Enter";
                    if (caseflag14)
                    {
                        // caseflag10 = true;
                        // caseflag11 = true;
                        // caseflag12 = true;
                        // caseflag13 = true;
                        ab[i] = cki.Key.ToString();
                        i++;
                        break;
                    }
                    else break;
                case 15:
                    // StringFromConsole = "Escape";
                    // caseflag10 = true;
                    // caseflag11 = true;
                    // caseflag12 = true;
                    // caseflag13 = true;
                    caseflag14 = true;
                    ab[i] = cki.Key.ToString();
                    i++;
                    nFilled = -1;
                    break;
            }



            Console.Clear();
            Console.SetCursorPosition(0, 0);

            Console.Write(ConsoleString);



            if (cki.Key == ConsoleKey.Enter && caseflag14) break;

        } while (cki.Key != ConsoleKey.Escape);


        if (debugFlag) PrintStringArrayInLine(ab, 10);

        // Assign double  values to dArray elements from ConsoleString string

        i = 0;    //dArray index
        string[] subs = ConsoleString.Split(' ');
        if (nFilled != -1)
        {
            nFilled = 0;           // Счетчик числа заполненных в dArray значений - инициализация - обнуляем
        }
        else
        {
            Console.WriteLine("Вы прервали ввод, нажав Esc. Повторите последнюю транзакцию, пожалуйста.");
            return false;
        }
        foreach (string sub in subs)
        {

            // try
            // {
            //  dArray[i] = Convert.ToDouble(sub);
            dArray[i] = sub;
            nFilled++;      // Счетчик числа заполненных в dArray значений - добавляем 1 при заполнении очередного значения
            // }
            // catch (FormatException)
            // {
            //     Console.WriteLine("Unable to convert '{0}' to a Double.", sub);
            //     flagOK = false;
            //     break;
            // }
            // catch (OverflowException)
            // {
            //     Console.WriteLine("'{0}' is outside the range of a Double.", sub);
            //     flagOK = false;
            //     break;
            // }
            if (i < N - 1) i++;    //  движемся по формируемому массиву значений
            else break;     //  до достижения его границы, что сверху границы длины массива остаются неприсвоенным
        }
        return flagOK;

    }
    public static bool FillArrayConsoleString(string[] MyArray, bool debugFlag)
    //
    // Метод заполнения массива символьными строками с консоли
    // На вход полается массив, элементы которого являются символьными строками, который нужно заполнить, а также значение флага выполнения в отладочном режиме
    // (в отладочном режиме  выдаются на консоль содержание рабочих массивов)
    // Возвращается заполненный значениями массив и булевское значение успешного (неуспешного) 
    // завершения работы метода
    //  МЕТОД В ТАДИИ ОТЛАДКИ!!!11
    {
        int N = MyArray.Length;

        int M = 0;     // Счетчик заполненных элементов массива MyArray


        while (M < N)
        {
            int i = N - M;
            string[] dArray = MyLibrary.CreateStringArray(i);

            if (MyLibrary.DataEntryForArrayString(dArray, M, out int nassigned, false))
            {
                if (nassigned == -1)
                {
                    return false;
                }
                for (int j = 0; j < MyLibrary.Min(i, nassigned); j++)  //  В MyArray заносятся только первые N значений (в соответствии с его длиной)
                {
                    MyArray[M + j] = dArray[j];     //  Дописываем в массив MyArray с которым обращались из основной программы
                }

                M = M + nassigned;     //  обновляем количество заполненных элементов массива MyArray
            }
            else
            {
                Console.WriteLine("При вводе произошла ошибка. Повторите последнюю транзакцию, пожалуйста.");

                // PrintRealArrwithHeader("Распечатываем рабочий массив (отладка)", dArray,10);
                // PrintRealArrwithHeader("Распечатываем возвращаемый массив (отладка)", MyArray,10);


            }
            if (debugFlag)
            {
                Console.WriteLine('\n' + "Распечатываем рабочий массив (отладка)");
                MyLibrary.PrintStringArray(dArray);
                // PrintRealArrwithHeader("Распечатываем возвращаемый массив (отладка)", MyArray, 10);
                Console.WriteLine('\n' + "Распечатываем возвращаемый массив (отладка)");
                MyLibrary.PrintStringArray(MyArray);
            }
        }

        return true;
    }
    //
    // Метод создания одномерного массива с заданным количеством элементов
    // Элементы являются символьными строками
    // Возвращает инициализированный массив
    // 
    public static string[] CreateStringArray(int count)
    {
        return new string[count];
    }
    //
    // Метод присваивания значений элементам массива, которыми являются символьные строки
    // На вход подается массив, который нужно заполнить
    // Возвращается заполненный значениями массив и булевское значение успешного (true) или неуспешного (false) 
    // завершения работы метода
    public static bool FillArrayConsoleTextString(string[] MyArray)
    {
        int N = MyArray.Length;
        Console.Clear();
        Console.WriteLine('\n' + "Введите элементы массива строк. Кол-во элементов:" + $"{N,2}" );
        Console.WriteLine(">>>>>------>>>>>" + '\n');
        int position = 0;
string lline;

        while (position < N)

        {
            Console.WriteLine("Введите элемент № " + $"{position+1}");
            Console.WriteLine("(чтобы прервать ввод нажмите Ctrl+Z, затем ENTER)");
            lline = Console.ReadLine();
            if (lline == null) return false;
            else
            {
                MyArray [position] = lline;
                position++;
            }  
        }
        return true;
    }
}