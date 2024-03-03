using AplicacaoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacaoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public List<Produto> produtos = [];

        public void OnGet()
        {
            for (int i = 1; i < 10; i++)
            {
                Produto produto = new Produto();
                produto.Id = i;
                produto.Nome = $"produto {i}";
                produto.Valor = i + .99;
                produtos.Add(produto);
            }
        }
    }
}
