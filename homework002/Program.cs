string inputString = "HeLLo WorLD";
string lowerCaseString = "";

foreach (char c in inputString)
{
    if (Char.IsUpper(c))
    {
        lowerCaseString += Char.ToLower(c);
    }
    else
    {
        lowerCaseString += c;
    }
}

Console.WriteLine(lowerCaseString);