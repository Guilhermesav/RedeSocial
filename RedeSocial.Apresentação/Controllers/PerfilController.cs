using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RedeSocial.Apresentação.Models;

namespace RedeSocial.Apresentação.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil2
        public ActionResult Index()
        {
            return View();
        }

        // GET: Perfil2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Perfil2/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Perfil2/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(PerfilViewModel perfil)
        {
            try
            {
                HttpClient clienteHttp = new HttpClient();

                string perfilSerializado = JsonConvert.SerializeObject(perfil);

                string mediaType = "application/json";

                var codificacao = Encoding.UTF8;

                StringContent conteudo = new StringContent(perfilSerializado, codificacao, mediaType);

                var resposta = clienteHttp.PostAsync("http://localhost:53054/api/perfil", conteudo).Result;

                return RedirectToAction("index","home"); 
            }
            catch
            {
                return View();
            }
        }

        // GET: Perfil2/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {

            return View();
        }

        // POST: Perfil2/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit(int id, PerfilViewModel perfil)
        {
            try
            {
                
                HttpClient clienteHttp = new HttpClient();

                string perfilSerializado = JsonConvert.SerializeObject(perfil);

                string mediaType = "application/json";

                var codificacao = Encoding.UTF8;

                StringContent conteudo = new StringContent(perfilSerializado, codificacao, mediaType);

                var resposta = clienteHttp.PutAsync("http://localhost:53054/api/perfil", conteudo).Result;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Perfil2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Perfil2/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}