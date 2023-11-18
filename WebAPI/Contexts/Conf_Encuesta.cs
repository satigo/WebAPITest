using System.ComponentModel.DataAnnotations;

namespace WebAPI.Contexts
{
    public class Conf_Encuesta
    {

        [Key]
        public int? Id_encuesta { get; set; }
        public string? Nombre_encuesta { get; set; }
        public string? Descripcion_Encuesta { get; set; }
        public string? Listado_Campos { get; set; }
        public bool? Estado { get; set; }
    }
}
