namespace Texts
{
    internal class Vigenere
    {
        private readonly string _alphabet;

        public Vigenere(string alphabet)
        {
            _alphabet = alphabet;
        }

        public string Encode(string text, string keyword)
        {
            var cipher = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                var j = i % keyword.Length;
                var col = _alphabet.IndexOf(keyword[j]);
                var row = _alphabet.IndexOf(text[i]);
                cipher += GetTabulaRecta(row, col);
            }
            return cipher;
        }

        public string Decode(string cipher, string keyword)
        {
            var text = string.Empty;
            for (var i = 0; i < cipher.Length; i++)
            {
                var j = i % keyword.Length;
                var col = _alphabet.IndexOf(keyword[j]);
                var row = _alphabet.IndexOf(cipher[i]);
                text += _alphabet[(row - col + _alphabet.Length) % _alphabet.Length];
            }
            return text;
        }

        private char GetTabulaRecta(int row, int col)
        {
            return _alphabet[(row + col) % _alphabet.Length];
        }
    }
}
