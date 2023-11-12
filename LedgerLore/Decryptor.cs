using System.Text;

namespace CodeChallenge1;
internal static class Decryptor
{
    public static string Decrypt(string encryptedText, string key)
    {
        byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        byte[] decryptedBytes = new byte[encryptedBytes.Length];

        for (int i = 0; i < encryptedBytes.Length; i++)
        {
            decryptedBytes[i] = (byte)(encryptedBytes[i] ^ keyBytes[i % keyBytes.Length]);
        }

        return Encoding.UTF8.GetString(decryptedBytes);
    }
}
