using Microsoft.AspNetCore.Mvc;
using PrecisoPRO.Interfaces;
using PrecisoPRO.Models;

namespace PrecisoPRO.Controllers
{
    public class BuscarCNDs : Controller
    {
        //contexto do banco de dados
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IEstadoRepository _estadoRepository;
        private readonly IEmpresaEstadoRepository _empresaEstadoRepository;
        IEnumerable<Empresa>? listaEmpresas; //Lista enumerada
        IEnumerable<Estado>? listaEstados; //lista de estados
        IEnumerable<EmpresaEstado>? listaEmpresaEstados; //lista de empresas e estados


        //CONSTRUTOR
        public BuscarCNDs(IEmpresaRepository empresaRepository, IEstadoRepository estadoRepository, IEmpresaEstadoRepository empresaEstadoRepository)
        {
            _empresaRepository = empresaRepository;
            _estadoRepository = estadoRepository;
            _empresaEstadoRepository = empresaEstadoRepository;
        }
        public async Task<IActionResult> Index(string cnpj, string ie, string  finalidade="CADASTRO")
        {
            this.listaEmpresaEstados = await _empresaEstadoRepository.GetAllAsyncNoTracking();
            this.listaEstados = await _estadoRepository.GetAllAsyncNoTracking();
            var grupos = this.listaEmpresaEstados.GroupBy(e => e.UfEstado);

            // Criar uma lista para armazenar a contagem de cada estado
            var contagemPorEstado = new List<Tuple<string, int>>();

            // Iterar pelos grupos e contar a quantidade em cada grupo
            foreach (var grupo in grupos)
            {
                var estado = grupo.Key;
                var quantidade = grupo.Count();

                contagemPorEstado.Add(new Tuple<string, int>(estado, quantidade));
            }

           
            ViewBag.ContagemPorEstado = contagemPorEstado;
            ViewBag.Estados = this.listaEstados.ToList();

            return View(this.listaEmpresaEstados);
        }
    }
}
