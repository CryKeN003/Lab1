Console.WriteLine("Введите количество жителей в государстве");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите площадь территории государства");
double b = Convert.ToDouble(Console.ReadLine());
double q = a / b; //Формула плотности населения
Console.WriteLine($"Плотность населения = {q}");