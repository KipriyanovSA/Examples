// 1 группа методов ничего не принимают, ничего не возвращают

void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();

// 2 группа методов ничего не возращают, но могут принимать аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст");
// Method2(msg: "Текст сообщения") - msg обращение к аргументу и его значению

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4); - 4 к-во повторений
// Method21(msg: "Текст", count: 4); 
// Method21(count: 4, msg: "Новый текст"); - обращение к конкретному аргументу по имени, порядок не важен

// 3 группа методов что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3(); year принимает значение из return
// Console.WriteLine(year); - вывод значения year

// 4 группа методов принимают и возвращают значения

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
// string res = Method4(10, "Z"); - 10 повторения текста в ковычках
// Console.WriteLine(res); res - вызов результата

string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) // Вариант с циклом for
    {
        result = result + text;
    }
    return result;
}
string res = Method41(10, "Z");
Console.WriteLine(res);