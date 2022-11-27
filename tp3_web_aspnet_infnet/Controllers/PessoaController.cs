using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using tp3_web_aspnet_infnet.DataSource;
using tp3_web_aspnet_infnet.Models;

namespace tp3_web_aspnet_infnet.Controllers
{
    public class PessoaController : Controller
    {

        public readonly DAPessoa daPessoa;

        // GET: pessoa
        public PessoaController(DAPessoa daPessoa)
        {
            this.daPessoa = daPessoa;
        }


        //Tabela
        public ActionResult Index()
        {
            return View(daPessoa.pessoas);
        }

        // GET: pessoa/details/id
        public ActionResult Details(int? id)
        {


            if (id != null)
            {
                foreach (var pessoa in daPessoa.pessoas)
                {
                    if (pessoa.Id == id)
                    {
                        return View(pessoa);
                    }
                }

            }        
              

            return View();
        }

        //Forms
        public ActionResult Create()
        {
            return View();
        }

        // POST: pessoa/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pessoa pessoa)
        {
            try
            {
                daPessoa.pessoas.Add(pessoa);
                return View("Index", daPessoa.pessoas);
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET: PessoaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PessoaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PessoaController/Delete/5
        public ActionResult Delete(int id)
        {

            daPessoa.pessoas.Remove(
                    daPessoa.pessoas.First(p => p.Id == id)

                );
            return View("Index", daPessoa.pessoas);
        }

        //// POST: PessoaController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
