// Demo139 - Claims
// TOSINSO C# Mega Course

using System.Security.Claims;

ClaimsIdentity identity = new ClaimsIdentity();

identity.AddClaim(new Claim(ClaimTypes.Name, "Hossein Ahmadi"));
identity.AddClaim(new Claim(ClaimTypes.Role, "content-manager"));
identity.AddClaim(new Claim(ClaimTypes.Email, "ahmadi@tosinso.com"));
identity.AddClaim(new Claim("UserMobile", "+989121111111"));

Console.WriteLine($"Name: {identity.Name}");

ClaimsPrincipal principal = new ClaimsPrincipal(identity);

Console.WriteLine($"Is in role Content Manager: {principal.IsInRole("content-manager")}");
Console.WriteLine($"Identity email: {principal.FindFirst(ClaimTypes.Email)?.Value}");
Console.WriteLine($"Identity mobile: {principal.FindFirst("UserMobile")?.Value}");