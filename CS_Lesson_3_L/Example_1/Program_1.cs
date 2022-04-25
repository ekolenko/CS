void Method1()
{

    Console.WriteLine("Author ...");

}

Method1();

void Method2(string msg)
{

    Console.WriteLine(msg);


}

Method2("Text message");

void Method21(string msg, int count)
{

    int i = 0;
    while (i < count)
    {

        Console.WriteLine(msg);
        i++;

    }


}

Method21(count: 6, msg: "Text message");

int Method3()
{

    return DateTime.Now.Year;

}

Console.WriteLine(Method3());

// string Method4(int count, string text)
// {

//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {

//         result += text;
//         i++;

//     }

//     return result;
// }

string Method4(int count, string text)
{

    
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result += text;
    }

    return result;
}
Console.WriteLine(Method4(10,"123"));

for (int i = 0; i <= 10; i++)
{

    for (int j = 0; j <= 10; j++)
    {

        Console.WriteLine($"{i} x {j} = {i*j}");

    }
    Console.WriteLine();

}
