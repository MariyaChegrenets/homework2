Console.Write("Введите число: ");
string a = Console.ReadLine();
if(a.Length > 2)
    Console.Write("Третья цифра числа:" + a[2]);
else    
    Console.Write("Третьей цифры нет");  