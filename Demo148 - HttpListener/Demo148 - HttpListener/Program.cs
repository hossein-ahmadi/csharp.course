// Demo148 - HttpListener
// TOSINSO C# Mega Course

using System.Net;
using System.Text;

var httpListener = new HttpListener();

httpListener.Prefixes.Add("http://127.0.0.100:7070/");

httpListener.Start();

while (true)
{
    Console.WriteLine("Waiting for request...");
    var context = await httpListener.GetContextAsync();
    Console.WriteLine($"Request {context.Request.RawUrl} received...");
    if (context.Request.RawUrl?.Equals("/page1") ?? false)
    {
        InitializeResponse(context.Response, HttpStatusCode.OK, "This is <b>your</b> response");
    }
    else
    {
        InitializeResponse(context.Response, HttpStatusCode.NotFound, "Request resource not found!");
    }
}

void InitializeResponse(HttpListenerResponse response,HttpStatusCode code, string responseText)
{
    var responseBytes = Encoding.UTF8.GetBytes(responseText);
    response.StatusCode = (int)code;
    response.ContentType = "text/html";
    response.ContentEncoding = Encoding.UTF8;
    response.ContentLength64 = responseBytes.Length;
    response.OutputStream.Write(responseBytes, 0, responseBytes.Length);
    response.Close();
}