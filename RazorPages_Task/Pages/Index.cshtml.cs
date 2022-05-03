using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_Task.DATA;
using RazorPages_Task.Entities;
using RazorPages_Task.Services;

namespace RazorPages_Task.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;

        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }

        public List<Person> Persons { get; set; }

        public void OnGet()
        {
            Persons = _repository.GetAll().ToList();
        }

    }
}
