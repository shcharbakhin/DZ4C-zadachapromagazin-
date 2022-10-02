//Есть магазин "Еда"
//В магазине есть охранник
//Охранник ведёт запись всех, кто заходит в магазин
//Охранник ведёт запись всех, кто выходит из магазин
//Зайти и выйти можно в целый час.
//Выяснить в какой промежуток времени было больше всего посетителей
//Данные вводятся парами: приход-уход
//Максимум 100 покупателей
//Входные данные
//10-12
//11-13
//9-12
//Ответ
//11-12
//создание массива 0-23
//

// Структура задачи:
//1.Ввести данные А и Б
//2. Какие значения входят в промежуток от А до Б
//3. добавить полученные данные в соотв колонки массива
//4. анализ полученных данных после введения всех значений
//5. поиск мах по индексу значения по 
//6. Вывод max
{
    Console.WriteLine("Распределение количества посетителей в магазине по времени");
    Console.Write("0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23");
    Console.WriteLine(" ");
    int[] hour = new int[24];
    int c = 0;
    for (int i = 0; i < 10; i++)
    {
        Console.Write(hour[c] + " ");
        c++;
    }
    for (int i = 0; i < 14; i++)
    {
        Console.Write(hour[c] + "  ");
        c++;
    }
    Console.WriteLine(" ");
    Console.WriteLine("Введите общее количество посетителей");
    Random rand = new Random(20);
    int posetiteli;
    posetiteli = rand.Next(20);
    for (int i = 0; i < posetiteli; i++)
    {
        c = 0;
        Random rnd = new Random(24);
        int A;
        A = rnd.Next(24);
        int B;
        B = rnd.Next(24);
        int elem = B - A;
        for (int j = 0; j < elem + 1; j++)
        {
            if (A < 24 && B < 24)
            {
                if (A <= B)
                {
                    if (hour[A] < 100)
                    {
                        hour[A] = hour[A] + 1;
                        Console.WriteLine(A);
                        A = A + 1;
                    }
                    else
                    {
                        Console.WriteLine("Столько посетителей быть в течения часа не может");
                    }
                }
                else
                {
                    Console.WriteLine("Посетитель не может находиться в магазине больше суток");
                }
            }
            else
            {
                Console.WriteLine("В сутках всего 24 часа");
            }
        }
    }
    Console.WriteLine("Распределение количества посетителей в магазине по времени");
    Console.Write("0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23");
    Console.WriteLine(" ");
    for (int i = 0; i < 10; i++)
    {
        Console.Write(hour[c] + " ");
        c++;
    }
    for (int i = 0; i < 14; i++)
    {
        Console.Write(hour[c] + "  ");
        c++;
    }
    int max = hour.Max();
    int index = Array.FindLastIndex(hour, delegate (int i) { return i == max; });
    Console.WriteLine(" ");
    Console.WriteLine("Час, в который было максимальное количество посетителей: {0}", index);
    Console.Write("Максимальное количество посетителей: ");
    Console.Write(max);
}


