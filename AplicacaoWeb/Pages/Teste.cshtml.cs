using AplicacaoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacaoWeb.Pages
{
    public class TesteModel : PageModel
    {
        private readonly ILogger<TesteModel> _logger;

        public TesteModel(ILogger<TesteModel> logger)
        {
            _logger = logger;
        }

        public List<Pessoa> pessoas = [];

        public void OnGet()
        {
            for (int i = 1; i < 10; i++)
            {
                pessoas.Add(new Pessoa {  
                    Nome = $"nome {i}", 
                    Idade = $"{i * 10}", 
                    Cpf = $"{i + 1}{i + 2}{i + 3}"
                });
            }
        }
    }
}
