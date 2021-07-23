using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Person> Persons { get; set; }

        public void OnGet()
        {
            Persons = new List<Person>
            {
                new Person("Kla", "Sylvanus", 60),
                new Person("Eté", "Benoît", 22),
                new Person("Brindou", "Junior", 25),
                new Person("Coulibaly", "Losséni", 24)
            };
        }
    }
}
