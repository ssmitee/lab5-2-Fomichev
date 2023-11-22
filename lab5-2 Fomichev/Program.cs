Console.WriteLine("Введите строку:");
string str = Console.ReadLine();

char[] charArray = str.ToCharArray();

for (int i = 0; i < charArray.Length; i++)
{
    if (charArray[i] == 'я')
    {
        charArray[i] = ' ';
    }
    else
    {
        charArray[i] = (char)(charArray[i] + 1);
    }
}

string newString = new string(charArray);

Console.WriteLine("Измененная строка: " + newString);
