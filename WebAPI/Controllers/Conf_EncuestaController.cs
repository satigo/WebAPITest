using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Contexts;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class Conf_EncuestaController : Controller
    {
        private readonly ILogger<Conf_EncuestaController> _logger;
        private readonly AppDbContext context;
        public Conf_EncuestaController( AppDbContext context)
        {
            this.context = context;
        }

        // GET: Conf_EncuestaController
        public IActionResult Index(int id)
        { Camp_EncuestaModel campo = new Camp_EncuestaModel();
            
                campo.Id_encuesta = id;                
            

            return View(campo);            
        }

        // GET: Conf_EncuestaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Conf_EncuestaController/Create
       
        public async Task<IActionResult> Create(Camp_EncuestaModel modelo )
        {
           
                           
                context.Camp_Encuesta.Add(modelo);
                await context.SaveChangesAsync();
                
            
           /* else
            {
                var cEncuesta = await context.Conf_Encuesta.FindAsync(conf.Id_encuesta);
                cEncuesta.Nombre_encuesta = conf.Nombre_encuesta;
                cEncuesta.Descripcion_Encuesta = conf.Descripcion_Encuesta;
                cEncuesta.Listado_Campos = conf.Listado_Campos;
                await context.SaveChangesAsync();

            }*/
            return RedirectToAction("Index");
            
        }
       
        

        // GET: Conf_EncuestaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Conf_EncuestaController/Edit/5
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

        // GET: Conf_EncuestaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Conf_EncuestaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
