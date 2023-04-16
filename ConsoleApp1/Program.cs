

        Console.WriteLine("Введите сумму ежемесячного пополнения");
        string text = Console.ReadLine();
        int money = Convert.ToInt32(text);

        if (money < 1000)
        {
            Console.WriteLine("Извините, вы слишком нищий для нашего банка");
        }
        else
        {
            Console.WriteLine("Сумма дивидендов за год:");

            int a = money * 12;
            double c;
            if (money < 5000)
            {
                c = 0.1;
            }

            else
            {
                c = 0.3;
            }
            double b = a * c;
            double d = Convert.ToInt32(b);
            double x = a + d;
            x = Convert.ToInt32(x);
            Console.WriteLine(x);
        }
        Console.ReadKey();
