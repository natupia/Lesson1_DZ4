// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 2 до N
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
        int res = 1;
       
        if (res == 1)

        {
         res += 1;
        }

        while (res <= num)

        {
            Console.WriteLine(res);
            res += 2;
        }