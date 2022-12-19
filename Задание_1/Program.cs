System.Console.WriteLine("Введите номер сектора:");
int input1 = int.Parse(Console.ReadLine());
String result = "";
if (input1 == 1)
{
    result = $"х начинается с {1} до {int.MaxValue}. y начинается с {1} до {int.MaxValue}";
}
else if (input1 == 2)
{
    result = $"х начинается с {-1} до {int.MinValue}. y начинается с {1} до {int.MaxValue}";
}
else if (input1 == 3)
{
    result = $"х начинается с {-1} до {int.MaxValue}. y начинается с {-1} до {int.MinValue}";
}
else if (input1 == 4)
{
    result = $"х начинается с {1} до {int.MaxValue}. y начинается с {-1} до {int.MinValue}";
}
System.Console.WriteLine(result);