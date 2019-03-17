using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Race_boat_app.Models;

namespace Race_boat_app.Controllers
{
    public class TeamController : Controller
    {

        static HttpClient client = new HttpClient();

        

        public async Task<IActionResult> All()
        {
            List<Team> teams = await GetTeamsAsync("https://localhost:44389/api/1.0/team");
            List<User> users = new List<User>();
            foreach(var user in teams)
            {
                User usr = await GetUserAsync("https://localhost:44389/api/1.0/user/" + user.CaptainID);
                users.Add(usr);
            }
            
            return View("Teams", users);
        }

        static async Task<List<Team>> GetTeamsAsync(string path)
        {
            List<Team> teams = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                teams = await response.Content.ReadAsAsync<List<Team>>();
            }
            return teams;
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
    }
}