while (true)
{
    float x = float.Parse(Console.ReadLine());
    string z = Console.ReadLine();
    switch (z)
    {
        case "+":
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine(x + y);
            break;
        case "-":
            y = float.Parse(Console.ReadLine());
            Console.WriteLine(x - y);
            break;
        case "*":
            y = float.Parse(Console.ReadLine());
            Console.WriteLine(x * y);
            break;
        case "/":
            y = float.Parse(Console.ReadLine());
            Console.WriteLine(x / y);
            break;
    }
}