using Demo144___WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo144___WebApi.Controllers;

public class HomeController : ControllerBase
{
    private static Dictionary<int, Models.User> users = new()
    {
        [1] = new User(){Id = 1, Firstname = "Hossein", Lastname = "Ahmadi"},
        [2] = new User() { Id = 2, Firstname = "Mohammad", Lastname = "Nasiri" },
        [3] = new User() { Id = 3, Firstname = "Mehdi", Lastname = "Adeli" }
    };

    [HttpGet("/")]
    public ActionResult<object> Index()
    {
        return new
        {
            status = "ok"
        };
    }

    [HttpGet("/users/get/{id}")]
    public ActionResult<object> GetPerson(int id)
    {
        if (!users.ContainsKey(id))
            return NotFound();

        return users[id];
    }

    [HttpPost("/users/add")]
    public ActionResult<object> AddPerson([FromBody]Models.User user)
    {
        users.Add(user.Id, user);

        return new
        {
            status = "ok"
        };
    }

    [HttpPost("/users/delete/{id}")]
    public ActionResult<object> DeletePerson(int id)
    {
        if (!users.ContainsKey(id))
            return NotFound();

        users.Remove(id);

        return new { status = "ok" };
    }
}