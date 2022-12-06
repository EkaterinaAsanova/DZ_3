//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");
string text = Console.ReadLine();
int number = 0;
bool success = int.TryParse(text, out number);
if (success == true)
    {
        if ((number <= 99999) && (number >= 10000))
        {
        string output = "";
        for (int i = 0; i < text.Length; i++)
            output = text[i] + output;
                
        if (text == output)
            Console.WriteLine("Число {0} является палиндромом", text);
        else
            Console.WriteLine("Число {0} не палиндромом", text); 
        }
        else
        Console.WriteLine("Ошибка. Ввод пятизначного числа"); 
    }
else
Console.WriteLine("Ошибка. Требуется ввод числа");