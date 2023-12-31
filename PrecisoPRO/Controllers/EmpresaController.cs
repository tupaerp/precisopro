﻿using Microsoft.AspNetCore.Mvc;
using PrecisoPRO.Interfaces;
using PrecisoPRO.Models;
using PrecisoPRO.Models.ViewModels;
using PrecisoPRO.Services;
using System.Data;
using X.PagedList;

namespace PrecisoPRO.Controllers
{
    public class EmpresaController : Controller
    {
        //contexto do banco de dados
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IEstadoRepository _estadoRepository;
        IEnumerable<Empresa>? listaEmpresas; //Lista enumerada
        IEnumerable<Estado>? listaEstados; //lista de estados
       
        public EmpresaController(IEmpresaRepository empresaRepository, IEstadoRepository estadoRepository)
        {
            _empresaRepository = empresaRepository;
            _estadoRepository = estadoRepository;
                                   
        }   
        public async Task<IActionResult> Index(string cnpj, string razao, string cidade, string fantasia, string estado, int numPagina = 1) 
        {
            this.listaEmpresas = await _empresaRepository.GetAllAsyncNoTracking();
            this.listaEstados = await _estadoRepository.GetAllAsyncNoTracking();

            if (cnpj != null)
            {
                this.listaEmpresas = this.listaEmpresas.Where(x => x.Cnpj.Contains(cnpj)).ToList();
                ViewBag.Cnpj = cnpj;
            }

            if (razao != null)
            {
                this.listaEmpresas = this.listaEmpresas.Where(x=>x.Razao.Contains(razao)).ToList();
                ViewBag.Razao = razao;
            }
            if(cidade != null)
            {
                this.listaEmpresas = this.listaEmpresas.Where(x => x.Cidade.Contains(cidade)).ToList();
                ViewBag.Cidade = cidade;
            }
            if (fantasia != null)
            {
                this.listaEmpresas = this.listaEmpresas.Where(x => x.Fantasia.Contains(fantasia)).ToList();
                ViewBag.Fantasia = fantasia;
            }
           
           
            if(estado !=null && estado != "")
            {
                this.listaEmpresas = this.listaEmpresas.Where(x => x.UF.Contains(estado)).ToList();
                ViewBag.Estado = estado;
            }
           
           
            //Busca os Estados
            ViewBag.Estados = this.listaEstados.ToList();

            //passa inicialmente dois parametros, o numero da pagina e o tamanho da página
            return View(this.listaEmpresas.ToPagedList(numPagina, 8));
        }

        //create
        public async Task<IActionResult> Incluir()
        {
            this.listaEstados = await _estadoRepository.GetAllAsyncNoTracking();
            //Busca os Estados
            ViewBag.Estados = this.listaEstados.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Incluir(EmpresaViewModel? empresaVM)
        {

            if (ModelState.IsValid)
            {
               
                var empresa = new Empresa
                {
                    Cnpj = empresaVM.Cnpj,
                    Ie = empresaVM.Ie,
                    Razao = empresaVM.Razao,
                    Fantasia = empresaVM.Fantasia,
                    Cep = empresaVM.Cep,
                    Endereco = empresaVM.Endereco,
                    Numero = empresaVM.Numero,
                    Cidade = empresaVM.Cidade,
                    UF = empresaVM.UF,
                    Telefone = empresaVM.Telefone,
                    Celular = empresaVM.Celular,
                    Principal = empresaVM.Principal,
                    Status = 1,
                    Data_Cad = DateTime.Now,
                    Data_Alt = DateTime.Now


                };
                try
                {
                    _empresaRepository.Adicionar(empresa);
                    TempData["Success"] = "Registro SALVO com sucesso";
                    return RedirectToAction("Index");
                }
                catch(Exception e)
                {
                    TempData["Error"] = "Probelmas ao salvar o registro, tente novamente";
                    return RedirectToAction("Index");
                }
               
                
            }
            else
            {
                ModelState.AddModelError("", "ERRO");
            }
            this.listaEstados = await _estadoRepository.GetAllAsyncNoTracking();
            //Busca os Estados
            ViewBag.Estados = this.listaEstados.ToList();
            return View(empresaVM);
        }
    }
}
