char[,] charArray = new char[,]
{
    { 'H', 'e', 'l', 'l', 'o' },
    { 'W', 'o', 'r', 'l', 'd' }
};

string str = "";

for (int i = 0; i < charArray.GetLength(0); i++)
{
    for (int j = 0; j < charArray.GetLength(1); j++)
    {
        str += charArray[i, j];
    }
}

Console.WriteLine(str);