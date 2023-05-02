Console.WriteLine("----Student1----");
Console.Write("Name : ");
string Name1 = Console.ReadLine();
Console.Write("Input Weight(kg) : ");
double W1 = double.Parse(Console.ReadLine());
Console.Write("Input Height(cm) : ");
double H1 = double.Parse(Console.ReadLine());

Console.WriteLine("----Student2-----");
Console.Write("Name : ");
string Name2 = Console.ReadLine();
Console.Write("Input Weight(kg) : ");
double W2 = double.Parse(Console.ReadLine());
Console.Write("Input Height(cm) : ");
double H2 = double.Parse(Console.ReadLine());

double BMI1 = Math.Round(W1 / Math.Pow(H1 / 100, 2), 2);
double BMI2 = Math.Round(W2 / Math.Pow(H2 / 100, 2), 2);

Console.WriteLine($"\n{Name1.ToUpper()}; BMI = {BMI1}");
Console.WriteLine($"{Name1.ToUpper()}; BMI = {BMI2}");

Console.WriteLine($"\nMax BMI = {Math.Max(BMI1, BMI2)}");