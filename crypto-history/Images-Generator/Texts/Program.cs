using Texts;

var alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";

var table = string.Empty;
for (var i = 0; i < alphabet.Length; ++i)
{
    var line = "&" + alphabet[i];
    for (var j = i; j < i + alphabet.Length; ++j)
    {
        line += "&" + alphabet[j % alphabet.Length];
    }
    table += line + Environment.NewLine;
}

File.WriteAllText("table.txt", table);

{
    var keyword = alphabet[11].ToString().ToUpperInvariant();
    var vigenere = new Vigenere(alphabet);
    var expectedText = "Мудрістьуділахліпшазамудрістьусловах".ToUpperInvariant();
    var cipher = vigenere.Encode(expectedText, keyword);
    var actualText = vigenere.Decode(cipher, keyword);
    if (actualText != expectedText)
    {
        throw new Exception();
    }
}


{
    var keyword = "в".ToUpperInvariant();
    var vigenere = new Vigenere(alphabet);
    var expectedText = "дважиттядвасонцядвакрила".ToUpperInvariant();
    var cipher = vigenere.Encode(expectedText, keyword);
    var actualText = vigenere.Decode(cipher, keyword);
    if (actualText != expectedText)
    {
        throw new Exception();
    }
}

{
    var trithemius = new Trithemius(alphabet);
    var expectedText = "міхоноша".ToUpperInvariant();
    var cipher = trithemius.Encode(expectedText);
    var actualText = trithemius.Decode(cipher);
    if (actualText != expectedText)
    {
        throw new Exception();
    }
}

{
    var keyword = "таємниця".ToUpperInvariant();
    var vigenere = new Vigenere(alphabet);
    var expectedText = "ХтосьуКиївхтосьуЛьвівмиуКобеляки".ToUpperInvariant();
    var cipher = vigenere.Encode(expectedText, keyword);
    var actualText = vigenere.Decode(cipher, keyword);
    if (actualText != expectedText)
    {
        throw new Exception();
    }
}

