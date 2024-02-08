public class Controller
{
    public string Encrypt(string plainText, int shift)
    {
        return new string(plainText.Select(c => char.IsLetter(c) ? (char)(((c + shift - (char.IsUpper(c) ? 'A' : 'a')) % 26) + (char.IsUpper(c) ? 'A' : 'a')) : c).ToArray());
    }

    public string Decrypt(string cipherText, int shift)
    {
        return new string(cipherText.Select(c => char.IsLetter(c) ? (char)(((c - shift - (char.IsUpper(c) ? 'A' : 'a') + 26) % 26) + (char.IsUpper(c) ? 'A' : 'a')) : c).ToArray());
    }
}
