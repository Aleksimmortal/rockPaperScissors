// 1 вариант игры компьютер всегда побеждает
while (true)
{
    Console.Clear();
    Console.WriteLine("Сыграйте в игру камень, ножницы, бумага с компьютером");
    Console.WriteLine("Если вы хотите выбрать камень нажмите - 1, если вы хотите выбрать ножницы нажмите - 2, если хотите выбрать бумагу нажмите - 3," + 
                      " если не хотите больше играть нажмите - 4");
    int choiceUser = int.Parse(Console.ReadLine());
    if (choiceUser == 4)
    {
        Console.WriteLine("Игра окончена");
        break;
    }
    Console.WriteLine("Если вам всё понятно нажмите любую клавишу, если непонятно всё равно нажмите");
    Console.ReadLine();
    Console.WriteLine("Вы выбрали " + (whatHand)choiceUser);
    Console.WriteLine("Теперь ходит компьютер....");
    if (choiceUser == 1)
    {
        Console.WriteLine("Компьютер ставит " + whatHand.бумагу);
        Console.WriteLine("К сожалению компьютер вас обыграл, попробуйте ещё раз!");
    }
    else if (choiceUser == 2)
    {
        Console.WriteLine("Компьютер ставит " + whatHand.камень);
        Console.WriteLine("К сожалению компьютер вас обыграл, попробуйте ещё раз!");
    }
    else if (choiceUser == 3)
    {
        Console.WriteLine("Компьютер ставит " + whatHand.ножницы);
        Console.WriteLine("К сожалению компьютер вас обыграл, попробуйте ещё раз!");
    }
    Console.WriteLine("Нажмите любую клавищу чтобы сыграть ещё раз");
    Console.ReadLine();
}


// 2 вариант игры компьютер всегда проигрывает
while (true)
{
    Console.Clear();
    Console.WriteLine("Сыграйте в игру камень, ножницы, бумага с компьютером");
    Console.WriteLine("Если вы хотите выбрать камень нажмите - 1, если вы хотите выбрать ножницы нажмите - 2, если хотите выбрать бумагу нажмите - 3," + 
                      " если не хотите больше играть нажмите - 4");
    int choiceUser = int.Parse(Console.ReadLine());
    if (choiceUser == 4)
    {
        Console.WriteLine("Игра окончена");
        break;
    }
    Console.WriteLine("Если вам всё понятно нажмите любую клавишу, если непонятно всё равно нажмите");
    Console.ReadLine();
    Console.WriteLine("Вы выбрали " + (whatHand)choiceUser);
    Console.WriteLine("Теперь ходит компьютер....");
    if (choiceUser == 1)
    {
        Console.WriteLine("Компьютер ставит " + whatHand.ножницы);
        Console.WriteLine("Вы победили, так держать!");
    }
    else if (choiceUser == 2)
    {
        Console.WriteLine("Компьютер ставит " + whatHand.бумагу);
        Console.WriteLine("Вы победили, так держать!");
    }
    else if (choiceUser == 3)
    {
        Console.WriteLine("Компьютер ставит " + whatHand.камень);
        Console.WriteLine("Вы победили, так держать!!");
    }
    Console.WriteLine("Нажмите любую клавищу чтобы сыграть ещё раз");
    Console.ReadLine();
}


enum whatHand
{
    камень=1,
    ножницы=2,
    бумагу=3
}