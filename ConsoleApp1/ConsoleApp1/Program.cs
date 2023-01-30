static void Zads1po3()
{
    try
    {
        Console.Write("Количество месяцев: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Количество работриков: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] a = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Введите з/п для {i + 1} работника, {j + 1} месяца: ");
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Clear();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write($"{a[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.Write("Для какого работника найти наибольшую з/п: ");
        int index = Convert.ToInt32(Console.ReadLine());
        int max = int.MinValue;
        for (int j = 0; j < m; j++)
        {
            if (a[index - 1, j] > max)
                max = a[index - 1, j];
        }
        Console.WriteLine($"Max: {max}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
//Zads1po3();

static void Zad4()
{
    try
    {
        Console.WriteLine("Введите дату начала отсчёта");
        DateTime dt1 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Введите дату конца отсчёта");
        DateTime dt2 = DateTime.Parse(Console.ReadLine());

        if (dt1 >= dt2) throw new Exception("Дата конца отсчёта не может быть больше");

        int days = Convert.ToInt32((dt2 - dt1).TotalDays);

        int holidays = 0;

        DateTime checkDateTime = dt1;

        while (checkDateTime <= dt2)
        {
            string month = checkDateTime.ToString("MM");
            if (checkDateTime.DayOfWeek == DayOfWeek.Saturday || checkDateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.Write($"{checkDateTime.ToString("dd.MM.yyyy (dddd)")} - выходной день. ");
                if (month == "12" || month == "01" || month == "02")
                    Console.WriteLine("Время года - зима;");
                else if (month == "03" || month == "04" || month == "05")
                    Console.WriteLine("Время года - весна;");
                else if (month == "06" || month == "07" || month == "08")
                    Console.WriteLine("Время года - лето;");
                else
                    Console.WriteLine("Время года - осень;");
                holidays++;
            }

            else
            {
                Console.Write($"{checkDateTime.ToString("dd.MM.yyyy (dddd)")} - рабочий день. ");
                if (month == "12" || month == "01" || month == "02")
                    Console.WriteLine("Время года - зима;");
                else if (month == "03" || month == "04" || month == "05")
                    Console.WriteLine("Время года - весна;");
                else if (month == "06" || month == "07" || month == "08")
                    Console.WriteLine("Время года - лето;");
                else
                    Console.WriteLine("Время года - осень;");
            }
            checkDateTime = checkDateTime.AddDays(1.0);
        }


        Console.WriteLine($"Количество рабочих дней = {days - holidays}");
        Console.WriteLine($"Количество выходных дней = {holidays}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
//Zad4();

static void Zad5()
{
    try
    {
        Console.Write("Введите возраст: ");
        int years = Convert.ToInt32(Console.ReadLine());
        if (years <= 0 || years > 99) throw new Exception("Возраст должен быть от 1 до 99");

        if (years >= 5 && years <= 20) Console.WriteLine($"{years} лет");
        else
        {
            int god = years / 10;
            switch (god)
            {
                case 1:
                    Console.WriteLine($"{years} год");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine($"{years} года");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine($"{years} лет");
                    break;
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    try
    {
        Console.Write("Введите день: ");
        int day = Convert.ToInt32(Console.ReadLine());
        if (day <= 0 || day > 31) throw new Exception("День должен быть в диапозоне" +
            "от 1 до 30");
        Console.Write("Введите месяц: ");
        int month = Convert.ToInt32(Console.ReadLine());
        if (month <= 0 || month > 12) throw new Exception("День должен быть в диапозоне" +
            "от 1 до 12");

        switch (month)
        {
            case 1:
                Console.WriteLine($"{day} января");
                break;
            case 2:
                Console.WriteLine($"{day} февраля");
                break;
            case 3:
                Console.WriteLine($"{day} марта");
                break;
            case 4:
                Console.WriteLine($"{day} апреля");
                break;
            case 5:
                Console.WriteLine($"{day} мая");
                break;
            case 6:
                Console.WriteLine($"{day} июня");
                break;
            case 7:
                Console.WriteLine($"{day} июля");
                break;
            case 8:
                Console.WriteLine($"{day} августа");
                break;
            case 9:
                Console.WriteLine($"{day} сентября");
                break;
            case 10:
                Console.WriteLine($"{day} октября");
                break;
            case 11:
                Console.WriteLine($"{day} ноября");
                break;
            case 12:
                Console.WriteLine($"{day} декабря");
                break;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}
//Zad5();

static void Individual()
{
    try
    {
        Random rnd = new Random();
        Console.Write("M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("K: ");
        int k = Convert.ToInt32(Console.ReadLine());

        if (k < 1 || k > m) throw new Exception("K должен быть больше 0 и меньше M");

        int[,] array = new int[m, n];
        int rows = array.GetUpperBound(0) + 1;
        int columns = array.Length / rows;
        int sum = 0;
        int multi = 1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = rnd.Next(1,10);
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < rows; i++)
        {
            sum = 0;
            multi = 1;
            for (int j = 0; j < columns; j++)
            {
                sum += array[k, j];
                multi *= array[k, j];
            }
        }
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Multi: {multi}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
Individual();