using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Race_boat_app.Models;

namespace Race_boat_app.Controllers
{
    public class EventController : Controller
    {
        static HttpClient client = new HttpClient();

        public IActionResult All()
        {
            return View("Events");
        }

        [HttpPost]
        public async Task<IActionResult> ViewEvent(String id)
        {
            EventIn event1 = await GetEventAsync("https://localhost:44389/api/1.0/event/"+id);
            return RedirectToAction("EventRegister", event1);
        }

        public async Task<ActionResult> EventRegister()
            {//This must be an async task 
                return View();
            }
        //[HttpGet("{id:length(24)}")]
        //public async Task<ActionResult> ViewEvent(string id)
        //{
        //    EventIn event1 = await GetEventAsync("https://localhost:44389/api/1.0/event/" + id);
        //    return View("EventView",event1);
        //}


        public async Task<List<EventIn>> AllEvents()
        {
            List<EventIn> events = await GetEventsAsync("https://localhost:44389/api/1.0/event");
            return events;
        }

        static async Task<List<EventIn>> GetEventsAsync(string path)
        {
            List<EventIn> events = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                events = await response.Content.ReadAsAsync<List<EventIn>>();
            }
            return events;
        }

    static async Task<EventIn> GetEventAsync(string path)
    {
        EventIn eventIn = null;
        HttpResponseMessage response = await client.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            eventIn = await response.Content.ReadAsAsync<EventIn>();
        }
        return eventIn;
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
