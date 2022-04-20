string text = "-Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Выдадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result += newValue;
        else result += text[i];

    }

    return result;
}

string newText = Replace(text,' ','-');
Console.WriteLine(newText);

newText = Replace(newText,'к','К');
Console.WriteLine(newText);

newText = Replace(newText,'с','С');
Console.WriteLine(newText);

