int.TryParse(Console.ReadLine(), out int n);
int result = (n / 100) % 10;
Console.WriteLine(result == 0 ? "третьей цифры нет" : result);