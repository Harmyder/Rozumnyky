namespace Texts

{
    internal class Trithemius
    {
        private readonly string _alphabet;

        public Trithemius(string alphabet)
        {
            _alphabet = alphabet;
        }

        public string Encode(string text)
        {
            var cipher = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                var col = i % _alphabet.Length;
                var row = _alphabet.IndexOf(text[i]);
                cipher += _alphabet[(col + row) % _alphabet.Length];
            }
            return cipher;
        }

        public string Decode(string cipher)
        {
            var text = string.Empty;
            for (var i = 0; i < cipher.Length; i++)
            {
                var col = i % _alphabet.Length;
                var letterIndex = _alphabet.IndexOf(cipher[i]);
                var row = (letterIndex - col + _alphabet.Length) % _alphabet.Length;
                text += _alphabet[row];
            }
            return text;
        }
    }
}
