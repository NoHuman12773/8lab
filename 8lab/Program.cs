try
{
    double a, b, c;
    Console.WriteLine("Введите первую сторону треугольника:"); //a
    a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите вторую сторону треугольника:"); //b
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите третью сторону треугольника:"); //c
    c = double.Parse(Console.ReadLine());
    
    double p = (a+b+c)/2;

    if ((a > 0 && b > 0 && c > 0) && (a + b > c && a + c > b && b + c > a))
    {
        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine("S = {0:F2}", S);
    }
    else
    {
        Console.WriteLine("Такого треугольника не существует");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}