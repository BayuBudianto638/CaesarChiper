var words = "Hello_World!";
string[] arrStringUpper = { "-", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
string[] arrStringLower = { "-", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
string[] arrChar = { " ", "-", "_", ".", "!", "~", "@", "$", "%", "^", "'", "/", "`", "(", ")", "{", "}", "[", "]", "?", "*", "+", "=", "&", "<", ">", "|" };
int index = 0;

var result = "";
var str = "";

foreach (var word in words)
{
    int permutasi = 98;

    var idxChar = Array.IndexOf(arrChar, word.ToString());

    if (idxChar > 0)
    {
        result = result + word;
        continue;
    }

    var isUpper = Char.IsUpper(word);
    if (isUpper)
    {
        index = Array.IndexOf(arrStringUpper, word.ToString());
    }

    var isLower = Char.IsLower(word);
    if (isLower)
    {
        index = Array.IndexOf(arrStringLower, word.ToString());
    }

    var isDigit = Char.IsDigit(word);
    if (isDigit)
    {
        result = result + word;
        continue;
    }

    if (permutasi > (arrStringUpper.Length - 1))
    {
        int x = (arrStringUpper.Length - 1) - index;
        permutasi = permutasi - x;
        while (permutasi > (arrStringUpper.Length - 1))
        {
            permutasi = permutasi - (arrStringUpper.Length - 1);
        }
    }
    else
    {
        permutasi = permutasi + index;
        if (permutasi > (arrStringUpper.Length - 1))
        {
            permutasi = permutasi - (arrStringUpper.Length - 1);
        }
    }

    if (isUpper)
    {
        str = arrStringUpper[permutasi];
    }
    else
    {
        str = arrStringLower[permutasi];
    }

    result = result + str;
}

Console.WriteLine($" Words : {words}");
Console.WriteLine($" Encrypted :{result}");
Console.ReadKey();