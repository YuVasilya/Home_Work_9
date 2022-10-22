Console.Clear();
string text = "1qaz2wsx3edc4rfv5tgb6yhn7ujm8ik,9ol.0p;[]";
string newtext = string.Empty;
char[] numbers = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', };
char[] chartext = text.ToCharArray();

for (int i = 0; i < chartext.Length; i++)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        if (chartext[i] == numbers[j]) chartext[i] = ' ';

    }
    newtext += chartext[i];
}

Console.WriteLine(newtext);

