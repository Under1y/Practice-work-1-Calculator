Console.WriteLine("сложение +\nвычитание -\nумножение *\nделение /\nвозведение в степень **\nквадратный корень sqrt\nпроцент от числа %\nостаток //");
bool w = true;
while (w)
{
    float x = float.Parse(Console.ReadLine());
    string z = Console.ReadLine();
    double n;
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
        case "//":
            y = float.Parse(Console.ReadLine());
            Console.WriteLine(x % y);
            break;
        case "%":
            y = float.Parse(Console.ReadLine());
            Console.WriteLine((x / 100) * y);
            break;
        case "**":
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(x, n));
            break;
        case "sqrt":
            Console.WriteLine(Math.Sqrt(x));
            break;
        case "x":
            w = false;
            break;
    }
}