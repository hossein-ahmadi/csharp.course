// Demo143 - URIs (Uniform Resource Identifier)
// TOSINSO C# Mega Course

Uri courseUri = new Uri("https://tosinso.com/courses/csharp-advance?utm_source=mainpage#description");

Console.WriteLine(courseUri.Scheme);
Console.WriteLine(courseUri.Host);
Console.WriteLine(courseUri.Port);
Console.WriteLine(courseUri.AbsolutePath);
Console.WriteLine(courseUri.Query);
Console.WriteLine(courseUri.Fragment);

UriBuilder uriBuilder = new UriBuilder("https", "tosinso.com");
uriBuilder.Path = "/courses/csharp-advnace";
uriBuilder.Query = "utm_source=mainpage";
uriBuilder.Fragment = "description";

Console.WriteLine(uriBuilder.Uri);

Console.ReadKey();