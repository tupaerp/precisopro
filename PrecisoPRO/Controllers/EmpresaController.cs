using Microsoft.AspNetCore.Mvc;
using X.PagedList;
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
        public async Task<IActionResult> Index(int numPagina = 1) 
        {
            this.listaEmpresas = await _empresaRepository.GetAll();

         
            //passa inicialmente dois parametros, o numero da pagina e o tamanho da página
            return View(this.listaEmpresas.ToPagedList(numPagina, 8));
        }
    }
}
