using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Api.Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Route("api/manager")]
    [Authorize(AuthenticationSchemes = "Bearer", Roles = "admin,employee")]
    public class ManagerController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

    }
}