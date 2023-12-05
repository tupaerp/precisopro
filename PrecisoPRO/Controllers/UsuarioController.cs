using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrecisoPRO.Interfaces;
using PrecisoPRO.Models;
using X.PagedList;

namespace PrecisoPRO.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IEmpresaRepository _empresaRepository;
        IEnumerable<Usuario>? listaUsuario;
        IEnumerable<Empresa>? listaEmpresas; 
        public UsuarioController(IUsuarioRepository usuarioRepository, IEmpresaRepository empresaRepository)
        {
            _usuarioRepository = usuarioRepository;
            _empresaRepository = empresaRepository;
        }

        // GET: Usuario
        public async Task<IActionResult> Index(int numPagina = 1)
        {
            this.listaUsuario = await _usuarioRepository.GetAll();
            return View(this.listaUsuario.ToPagedList(numPagina, 8));
            
        }
        public IActionResult Usuario()
        {
            return View();
        }



    }
}
