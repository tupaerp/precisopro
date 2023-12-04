using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrecisoPRO.Interfaces;
using PrecisoPRO.Models;

namespace PrecisoPRO.Controllers
{
    public class UsuarioController : Controller
    {
    private readonly IUsuarioRepository _usuarioRepository;
        IEnumerable<Usuario> listaUsuario;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            this.listaUsuario = await _usuarioRepository.GetAll();
            return View(listaUsuario);
        }

       

       
       
    }
}
