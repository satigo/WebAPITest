using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Conf_EncuestaModel
    {
        [Key]
        public int? Id_encuesta { get; set; }
        public string? Nombre_encuesta { get; set; }
        public string? Descripcion_Encuesta { get; set; }
        public string? Listado_Campos { get; set; }
        public bool? Estado { get; set; }
        
        
    }
}
