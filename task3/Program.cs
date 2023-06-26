
        Console.WriteLine("Введите координаты Xa: ");
        int Xa_user = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Введите координаты Xb: ");
        int Xb_user = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координаты Ya: ");
        int Ya_user = Convert.ToInt32(Console.ReadLine());
    
        Console.WriteLine("Введите координаты Yb: ");
        int Yb_user = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координаты Za: ");
        int Za_user = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координаты Zb: ");
        int Zb_user = Convert.ToInt32(Console.ReadLine());

        double dist = AB (Xa_user, Xb_user, Ya_user, Yb_user, Za_user, Zb_user);

        double AB (int Xa, int Xb, int Ya, int Yb, int Za, int Zb)
        {
            double AB = Math.Sqrt ((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya) + (Zb - Za) * (Zb - Za));
            return AB;
        }

        Console.WriteLine($"Distance between points: {dist:f3}");