// Demo141 - Asymmetric Encryption
// TOSINSO C# Mega Course

using System.Security.Cryptography;
using System.Text;

using var rsa = RSACryptoServiceProvider.Create(2048);

var publicKeyPath = "d:\\keys\\publickey.xml";
var privateKeyPath = "d:\\keys\\privatekey.xml";


if (!File.Exists(publicKeyPath))
    File.WriteAllText(publicKeyPath, rsa.ToXmlString(false));
if(!File.Exists(privateKeyPath))
    File.WriteAllText(privateKeyPath, rsa.ToXmlString(true));

// Use this statement for encryption
// rsa.FromXmlString(File.ReadAllText(publicKeyPath));

// Use this statement for decryption
rsa.FromXmlString(File.ReadAllText(privateKeyPath));

var encrypted = Convert.ToBase64String(rsa.Encrypt("Welcome to TOSINSO.COM"u8.ToArray(), RSAEncryptionPadding.Pkcs1));
Console.WriteLine("Encrypted: ");
Console.WriteLine(encrypted);
Console.WriteLine("Decrypted: ");
var encryptedBytes = Convert.FromBase64String(encrypted);
var decryptedBytes = rsa.Decrypt(encryptedBytes, RSAEncryptionPadding.Pkcs1);

Console.WriteLine(Encoding.UTF8.GetString(decryptedBytes));

