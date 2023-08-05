using mf_dev_backend;
using mf_dev_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend.Controllers 
{
    public class VeiculosController : Controller
    {
        private readonly AppDbContext _context;

        public VeiculosController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Veiculos.ToListAsync();

            return View(dados);
        }
    }
}
