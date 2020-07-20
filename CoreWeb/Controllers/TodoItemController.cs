using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CoreWeb.Models;
using CoreWeb.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreWeb.Controllers
{
    public class TodoItemController : Controller
    {
        public string webapiUrl = "https://localhost:44377/";
        public IActionResult Index()
        {
            TodoItemsViewModel data = new TodoItemsViewModel();
            data.todoItems = new List<TodoItem>();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(webapiUrl);
                HttpResponseMessage response = client.GetAsync("/api/TodoItems").Result;
                string result = response.Content.ReadAsStringAsync().Result;
                data.todoItems = JsonConvert.DeserializeObject<List<TodoItem>>(result);
            }

            return View(data);
        }

        [HttpPost]
        public IActionResult Create([FromForm] string addname)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("index");
            }

            TodoItem todoitem = new TodoItem();
            todoitem.Name = addname;
            todoitem.IsComplete = true;

            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(webapiUrl);
            string stringData = JsonConvert.SerializeObject(todoitem);
            var data = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("/api/TodoItems", data).Result;
            //var r = response.Content.ReadAsStringAsync( ).Result;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(long edit_id, string edit_name, bool edit_isComplete)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("index");
            }

            TodoItem todoItem = new TodoItem();
            todoItem.Id = edit_id;
            todoItem.Name = edit_name;
            todoItem.IsComplete = edit_isComplete;

            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(webapiUrl);
            string data = JsonConvert.SerializeObject(todoItem);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync($"/api/course/{todoItem.Id}", content).Result;
            return RedirectToAction("Index");
        }
    }
}
