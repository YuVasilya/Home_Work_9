Console.Clear();
string text = "1qaz";
string newtext = string.Empty;
char[] numbers = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', };
char[] chartext = text.ToCharArray();

for (int i = 0; i < chartext.Length; i++)
{
    for (int j = 0; j < numbers.Length; j++)
    {
        if (chartext[i] == numbers[j]) chartext[i] = ' ';

    }
}
Console.WriteLine(chartext);

