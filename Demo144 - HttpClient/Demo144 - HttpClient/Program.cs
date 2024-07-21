// Demo144 - HttpClient
// TOSINSO C# Mega Course

using System.Text;
using System.Text.Json;
using Demo144___HttpClient.Models;

while (true)
{
    Console.Clear();
    Console.WriteLine("1. Get user");
    Console.WriteLine("2. Add user");
    Console.WriteLine("3. Delete user");
    Console.WriteLine("4. Protected request");
    Console.WriteLine("5. Upload file");
    Console.WriteLine("6. Download file");
    Console.WriteLine("7. Exit");

    Console.WriteLine();
    Console.Write("Select an option: ");
    var selectedOption = Console.ReadLine();

    switch (selectedOption)
    {
        case "1":
        {
            Console.Clear();
            Console.Write("Enter user id: ");

            if (int.TryParse(Console.ReadLine(), out var userId))
            {
                using var httpClient = new HttpClient();
                var result = await httpClient.GetAsync("http://localhost:5292/users/get/" + userId);
                var stringResult = await result.Content.ReadAsStringAsync();
                var userModel = JsonSerializer.Deserialize<User>(stringResult, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });

                Console.WriteLine($"{userModel.Id} - {userModel.Firstname} {userModel.Lastname}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            break;
        }
        case "2":
        {
            Console.Clear();
            var user = new User();
            Console.Write("Id: ");
            user.Id = int.Parse(Console.ReadLine());
            Console.Write("Firstname: ");
            user.Firstname = Console.ReadLine();
            Console.Write("Lastname: ");
            user.Lastname = Console.ReadLine();

            using var client = new HttpClient();
            var postContent = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            var result = await client.PostAsync("http://localhost:5292/users/add", postContent);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            break;
        }
        case "3":
        {
            break;
        }
        case "4":
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Add("apikey", "12345");
            var response = await client.GetAsync("http://localhost:5292/protected/get/1");
            var result = await response.Content.ReadAsStringAsync();

            Console.Write("Press any key to continue...");
            Console.ReadKey();
            break;
        }
        case "5":
        {
            Console.Write("File to upload: ");
            var fileToUpload = Console.ReadLine();
            if (!File.Exists(fileToUpload))
            {
                Console.Write("File not exists!");
                Console.ReadKey();
                break;
            }

            var client = new HttpClient();

            using var fileStream = File.OpenRead(fileToUpload);
            using var requestMessage = new HttpRequestMessage(HttpMethod.Post, "http://localhost:5292/users/add/avatar");
            using var formData = new MultipartFormDataContent();
            formData.Add(new StreamContent(fileStream), "file", Path.GetFileName(fileToUpload));

            requestMessage.Content = formData;

            var responseMessage = await client.SendAsync(requestMessage);

            var result = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            break;
        }
        case "6":
        {
            Console.Write("Url to download: ");
            var urlToDownload = Console.ReadLine();

            using var client = new HttpClient();
            using var response = await client.GetAsync(urlToDownload);
            using var streamReader = new StreamReader(await response.Content.ReadAsStreamAsync());
            break;
        }
        case "7":
            return;
    }
}