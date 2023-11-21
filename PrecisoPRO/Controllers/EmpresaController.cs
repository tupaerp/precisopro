using Microsoft.AspNetCore.Mvc;
using PrecisoPRO.Interfaces;
using PrecisoPRO.Models;
using PrecisoPRO.Services;

namespace PrecisoPRO.Controllers
{
    public class EmpresaController : Controller
    {
        //contexto do banco de dados
        private readonly IEmpresaRepository _empresaRepository;
        IEnumerable<Empresa>? listaEmpresas; //Lista enumerada


        public EmpresaController(IEmpresaRepository empresaRepository)
        {

            _empresaRepository = empresaRepository;

           
        }
        public async Task<IActionResult> Index() 
        {
            this.listaEmpresas = await _empresaRepository.GetAll();

            return View(this.listaEmpresas);
        }
    }
}
