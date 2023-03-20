using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ASPCoreHomework3_4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string jsonResult { get; set; }

        public void OnGet()
        {

            Client[] clients = new Client[2];

           
            var client1 = new Client()
            {
                Id = 100,
                Login = "user1",
                Email = "user1@example.com"
            };

            clients[0] = client1;
            clients[1] = client1;
                    

            jsonResult = JsonSerializer.Serialize(clients);


        }

        

    }

    


    public class Client
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }
}
