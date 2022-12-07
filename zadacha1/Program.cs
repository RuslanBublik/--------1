Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
    {
        Console.WriteLine($"Большее число: {number1}");
        Console.WriteLine($"Меньшее число: {number2}");
    }
if(number2 > number1)
    {
        Console.WriteLine($"Большее число: {number2}");
        Console.WriteLine($"Меньшее число: {number1}");
    }    
if(number1 == number2)
    {
        Console.WriteLine("Числа равны");
    }    
