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
        public static string webapiUrl { get; set; }
        
        public IActionResult Index()
        {
            webapiUrl = "https://localhost:44377/";
            //"http://172.17.0.2/";
            //"https://localhost:44377/";

            try
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
            catch(Exception ex)
            {
                return Content(ex.Message.ToString());
            }
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
        public IActionResult Edit(long edit_id, string edit_name, string edit_isComplete)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("index");
            }

            TodoItem todoItem = new TodoItem();
            todoItem.Id = edit_id;
            todoItem.Name = edit_name;
            todoItem.IsComplete = string.IsNullOrEmpty(edit_isComplete) ? false : true;

            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(webapiUrl);
            string data = JsonConvert.SerializeObject(todoItem);
            var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync($"/api/TodoItems/{todoItem.Id}", content).Result;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(long del_id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("index");
            }

            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(webapiUrl);
            HttpResponseMessage response = client.DeleteAsync($"/api/TodoItems/{del_id}").Result;
            return RedirectToAction("Index");
        }
    }
}
