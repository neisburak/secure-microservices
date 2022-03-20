using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Movies.Client.Controllers
{
    [Authorize]
    public class RolesController : Controller
    {
        [Authorize(Roles = "user")]
        public IActionResult UserPage() => View();

        [Authorize(Roles = "admin")]
        public IActionResult AdminPage() => View();
    }
}