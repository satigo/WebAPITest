using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAPI.Contexts;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext context;
        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        { 
            List<Conf_EncuestaModel> conf_Encuesta = new List<Conf_EncuestaModel>();
            conf_Encuesta = context.Conf_Encuesta.ToList();
            return View(conf_Encuesta);
        }

        public IActionResult Conf_Encuesta(int id_conf)
        {
            ViewBag.Accion = "Nueva Configuracion";
            Conf_EncuestaModel modelo_conf_encuesta = new Conf_EncuestaModel();
            if (id_conf != 0) {
                modelo_conf_encuesta = context.Conf_Encuesta.FirstOrDefault(p => p.Id_encuesta == id_conf);
                ViewBag.Accion = "Editar Configuracion";
            }
            return View(modelo_conf_encuesta);
        }

        public async Task<IActionResult> Create(Conf_EncuestaModel conf) {
            bool response = false;
            if (conf.Id_encuesta == 0 || conf.Id_encuesta==null)
            {
                conf.Estado = true;
                context.Conf_Encuesta.Add(conf);
                await context.SaveChangesAsync();
                response = true;
            }
            else {
                var cEncuesta = await context.Conf_Encuesta.FindAsync(conf.Id_encuesta);
                cEncuesta.Nombre_encuesta= conf.Nombre_encuesta;
                cEncuesta.Descripcion_Encuesta = conf.Descripcion_Encuesta;
                cEncuesta.Listado_Campos = conf.Listado_Campos;
                await context.SaveChangesAsync();

            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Eliminar(int id_conf)
        {
            bool response = false;
            Conf_EncuestaModel modelo_conf_encuesta = new Conf_EncuestaModel();
            if (id_conf != 0)
            {
                modelo_conf_encuesta = context.Conf_Encuesta.FirstOrDefault(p => p.Id_encuesta == id_conf);
                modelo_conf_encuesta.Estado = false;

                await context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            else {
                return NoContent();
            }
            

            
            
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
