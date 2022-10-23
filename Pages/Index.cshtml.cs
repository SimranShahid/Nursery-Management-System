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
        //service ayy gi to use ho gi
        jsonFileBookService BookService;
        //book record any waly ko apny under store kry ga
        public IEnumerable<book> books;
        public IndexModel(
            ILogger<IndexModel> logger,
            jsonFileBookservice service)
        {
            _logger = logger;
            BookService = service;
        }

        public void OnGet()
        { //service ko initialize kr k book k andar store kr ly ga
            BookService.getBookRecord();
        }
    }
}
