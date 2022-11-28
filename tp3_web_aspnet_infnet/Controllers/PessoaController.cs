using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using tp3_web_aspnet_infnet.DataSource;
using tp3_web_aspnet_infnet.Models;

namespace tp3_web_aspnet_infnet.Controllers
{
    public class PessoaController : Controller
    {               

        //Tabela -OK
        public ActionResult Index()
        {
            return View(DAPessoa.Pessoas);
        }

        // GET: pessoa/details/id -OK 
        public ActionResult Details(int id)
        {
            var pessoa = DAPessoa.BuscaPessoaPorId(id);

            return View(pessoa);
        }

        //Forms
        public ActionResult Create()
        {
            return View();
        }

        // POST: pessoa/create -OK
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pessoa pessoa)
        {
            try
            {
                DAPessoa.AdicionarPessoa(pessoa);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PessoaController/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoa = DAPessoa.BuscaPessoaPorId(id); 
            return View(pessoa);
            
        }

        // POST: PessoaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pessoa pessoa)
        {
            try
            {
                DAPessoa.EditaPessoa(pessoa);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();            
            }          
        }

        // GET: PessoaController/Delete/5  -OK
        public ActionResult Delete(int id)       {


            return View(DAPessoa.BuscaPessoaPorId(id));
        }

        // POST: PessoaController/Delete/5   -OK
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Pessoa pessoa)
        {
            try
            {
                DAPessoa.DeletaPessoa(pessoa.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Busca(string nome)
        {
            var lista = DAPessoa.BuscaPessoaNome(nome);
            return View(lista);
        }

    }
}
