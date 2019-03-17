using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Race_boat_app.Models;

namespace Race_boat_app.Controllers
{
    public class HomeController : Controller
    {
        static HttpClient client = new HttpClient();
        private static readonly string passPhrase = "l%HJb5N^O@fl0K02H9PsxlR9algJTzK7ARBjJsd3fPG0&GwkrU";

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("UserLogin");
        }

        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> LoginUser(Login login)
        {
            string sendEmail = Crypto.Encrypt(login.Email, passPhrase);
            string sendPassword = Crypto.Encrypt(login.Password, passPhrase);
            Login logSend = new Login()
            {
                Email = sendEmail,
                Password = sendPassword
            };

            HttpResponseMessage response = await client.PostAsJsonAsync(
                "https://localhost:44389/api/1.0/login", logSend);
            response.EnsureSuccessStatusCode();
            var tempURL = response.Headers.Location;
            Console.WriteLine(tempURL);
            User tempUser = await GetUserAsync(tempURL.ToString());
            string id = tempUser.Id;
            string email = Crypto.Decrypt(tempUser.Email, passPhrase);
            OutLogin final = new OutLogin()
            {
                Email = email,
                Id = id
            };
            return View("Index");
            //OutLogin temp = response.Content.ReadAsAsync<OutLogin>();

        }

        
        static async Task<User> GetUserAsync(string path)
        {
            User user = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadAsAsync<User>();
            }
            return user;
        }


        [HttpPost]
        public async Task<ActionResult> AdminLogin(Login login)
        {
            string sendEmail = Crypto.Encrypt(login.Email, passPhrase);
            string sendPassword = Crypto.Encrypt(login.Password, passPhrase);
            Login logSend = new Login()
            {
                Email = sendEmail,
                Password = sendPassword
            };

            HttpResponseMessage response = await client.PostAsJsonAsync(
                "https://localhost:44389/api/1.0/adminlogin", logSend);
            Console.Write(response.IsSuccessStatusCode);
            response.EnsureSuccessStatusCode();
            var tempURL = response.Headers.Location;

            Console.WriteLine(tempURL);
            Admin tempAdmin = await GetAdminAsync(tempURL.ToString());
            string id = tempAdmin.Id;
            string email = Crypto.Decrypt(tempAdmin.Email, passPhrase);
            OutLogin final = new OutLogin()
            {
                Email = email,
                Id = id
            };
            return View("Index");
            //OutLogin temp = response.Content.ReadAsAsync<OutLogin>();

        }


        static async Task<Admin> GetAdminAsync(string path)
        {
            Admin admin = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                admin = await response.Content.ReadAsAsync<Admin>();
            }
            return admin;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        

    }
}
