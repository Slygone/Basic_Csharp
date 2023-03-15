string sentence = "The whole group of G2 loves C#.They find learning this language fun and easy!";
//indexOf
int index = sentence.IndexOf('.');
if (index != -1 && index + 1 < sentence.Length)
{
    string textAfterDot = sentence.Substring(index + 1);
    Console.WriteLine(textAfterDot.Trim());
}

//split
string[] splitSentence = sentence.Split(".");
Console.WriteLine(splitSentence[1].Trim());