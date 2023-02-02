bool isWork = true;

while(isWork)

{
    Console.Write("Введите номер задачи ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
            {
                Console.Write("Введите первое число: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine("max = " + a);
                }
                else Console.WriteLine("max = " + b);
                break;
            }
            case 2:
            {
                Console.Write("Введите первое число: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Введите третье число: ");
                int c = int.Parse(Console.ReadLine());
                {
                    int maxnum = a;
                    if (maxnum < b) maxnum = b;
                    if (maxnum < c) maxnum = c;
                    Console.WriteLine("Максимальное число - " + maxnum);
                }
                break;
            }
            case 3:
            {
                Console.Write("Введите число ");
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine("Целое число");
                }
                else Console.WriteLine("Нецелое число");
                break;
            }
            case 4:
            {
                Console.WriteLine("Введите число ");
                int a = int.Parse(Console.ReadLine());
                int divider = 2;
                if (a >= 2)
                {
                    while (divider <= a)
                    {
                        Console.WriteLine(divider + ", ");
                        divider += 2;
                    }
                }
                break;
            }

            case -1: isWork = false; break;
        }
    }
}