var s = "Always-Look-on-the-Bright-Side-of-Life";
int k = 5;
var strChiper = "";
string str = "-abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

var len = s.Length;
for (int i = 0; i < len; i++)
{
    if (s[i].ToString() == "-")
    {
        strChiper = strChiper + "-";
        continue;
    }

    int index = str.IndexOf(s[i]);

    if (index <= 26)
    {
        if (index + k > 26)
        {
            index = k - (26 - index);
        }
        else
        {
            index = index + k;
        }
    }
    else
    {
        index = index + k;
    }

    var sChiper = str.ElementAt(index);
    strChiper = strChiper + sChiper;
}

Console.WriteLine($"{strChiper}");
Console.ReadKey();