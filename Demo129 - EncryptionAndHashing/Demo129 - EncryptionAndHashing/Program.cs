// Demo129 - Security in .NET - Hashing
// TOSINSO C# Mega Course

Console.Write("Enter password: ");
var password = Console.ReadLine();

var md5Hasher = System.Security.Cryptography.MD5.Create();

var sha256Hasher = System.Security.Cryptography.SHA256.Create();

var passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

var hashedBytes = md5Hasher.ComputeHash(passwordBytes);
var hashedSha256Bytes = sha256Hasher.ComputeHash(passwordBytes);
        
var hashedString = Convert.ToBase64String(hashedBytes);
var hashedSha256String = Convert.ToBase64String(hashedSha256Bytes);

Console.WriteLine($"MD5: {hashedString}");
Console.WriteLine($"SHA256: {hashedSha256String}");