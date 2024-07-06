// Demo140 - Symmetric Encryption
// TOSINSO C# Mega Course

using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

Console.WriteLine("1. Encrypt file");
Console.WriteLine("2. Decrypt file");
Console.WriteLine();
Console.Write("Select an option: ");
var selectedOption = Console.ReadLine();

switch (selectedOption)
{
    case "1":
    {
        var filePath = "D:\\Files\\myfile.txt";
        var outputFile = filePath + ".aes";
        var keyFile = filePath + ".key";
        var aes = Aes.Create();

        aes.GenerateIV();
        aes.GenerateKey();
        var keyHolder = new KeyHolder()
        {
            IV = aes.IV,
            Key = aes.Key
        };
        var json = JsonSerializer.Serialize(keyHolder);
        File.WriteAllText(keyFile, json);
        var fileContent = File.ReadAllText(filePath);
        var fileContentBytes = Encoding.UTF8.GetBytes(fileContent);
        using var fileStream = File.Create(outputFile);
        using var cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(aes.Key, aes.IV), CryptoStreamMode.Write);
        cryptoStream.Write(fileContentBytes, 0, fileContentBytes.Length);
        cryptoStream.Flush();

        Console.Write("File encrypted...");
        Console.ReadKey();
        break;
        }
    case "2":
    {
        var filePath = "D:\\Files\\myfile.txt.aes";
        var keyFile = "D:\\Files\\myfile.txt.key";

        var keyModel = JsonSerializer.Deserialize<KeyHolder>(File.ReadAllText(keyFile));

        var aes = Aes.Create();
        aes.Key = keyModel.Key;
        aes.IV = keyModel.IV;

        using var fileStream = File.Open(filePath, FileMode.Open);
        using var cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(aes.Key, aes.IV), CryptoStreamMode.Read);
        var streamReader = new StreamReader(cryptoStream);
        var output = streamReader.ReadToEnd();
        File.WriteAllText("D:\\Files\\myfile.decrypted.txt", output);
        break;
    }
}


public class KeyHolder
{
    public byte[] Key { get; set; }
    public byte[] IV { get; set; }
}