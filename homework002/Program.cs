﻿string inputString = "Hello, my name ...";
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