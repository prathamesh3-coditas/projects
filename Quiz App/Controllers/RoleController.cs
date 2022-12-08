using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Quiz_App.Models;
using System.Composition.Convention;
using System.Data;

namespace Quiz_App.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        private readonly UserManager<IdentityUser> userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {

            var count = roleManager.Roles.Count();
            if (count == 0)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Administrator";
                var result = await roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
            }
            var allRoles = roleManager.Roles.ToList();
            return View(allRoles);
        }

        public IActionResult Create()
        {
            var role = new IdentityRole();
            return View(role);
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {

            var roleExists = await roleManager.RoleExistsAsync(role.Name);

            if (roleExists == true)
            {
                ViewBag.Msg = $"Role \"{role.Name}\" already exists";
                return View(role);
            }

           var res =  await roleManager.CreateAsync(role);
            if (res.Succeeded == true)
            {
                return RedirectToAction("Index");
            }

            ViewBag.ErrorMsg = "Role creation failed";
            return View(role);

        }


        public async Task<IActionResult> AssignRoleToUser()
        {
            var allRoles = roleManager.Roles;

            List<SelectListItem> roleList = new List<SelectListItem>();
            foreach (var item in allRoles)
            {
                roleList.Add(new SelectListItem(item.Name,item.Id));
            }
            ViewBag.Roles = roleList;



            var allUsers = userManager.Users;

            List<SelectListItem> userList = new List<SelectListItem>();
            foreach (var item in allUsers)
            {
                userList.Add(new SelectListItem(item.UserName, item.Id));
            }
            ViewBag.Users = userList;

            return View(new UserInRoles());
        }



        [HttpPost]
        public async Task<IActionResult> AssignRoleToUser(UserInRoles userInRole)
        {
            if (userInRole == null || userInRole.UserId == null || userInRole.RoleId == null)
            {
                // 1. Get All Roles
                var roles = roleManager.Roles;

                List<SelectListItem> roleItems = new List<SelectListItem>();
                foreach (var role in roles)
                {
                    roleItems.Add(new SelectListItem(role.Name, role.Id));
                }
                ViewBag.Roles = roleItems;

                // 2. Get All Users
                var users = userManager.Users;
                List<SelectListItem> usersItems = new List<SelectListItem>();
                foreach (var user in users)
                {
                    usersItems.Add(new SelectListItem(user.UserName, user.Id));
                }
                ViewBag.Users = usersItems;

                return View(new UserInRoles());
            }

            // 1. Check if USe Exist
            var UserExist = await userManager.FindByIdAsync(userInRole.UserId);
            // 2. Check Role Exists
            var RoleExist = await roleManager.FindByIdAsync(userInRole.RoleId);
            if (UserExist == null || RoleExist == null)
            {
                ViewBag.UserStatus = $"The USer {userInRole.UserId} does not exist";
                ViewBag.RoleStatus = $"The Role {userInRole.RoleId} does not exist";
                // Also Pass ViewBag for USers and Roles 
                return View(new UserInRoles());
            }

            // 3. Assign Role To User

            var result = await userManager.AddToRoleAsync(UserExist, RoleExist.Name);

            if (result.Succeeded)
                return RedirectToAction("Index");
            return View(new UserInRoles());

        }

    }
}
