using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Camp_EncuestaModel
    {
        [Key]
        public int? Id_encuesta { get; set; }
        public string? Nombre_campo { get; set; }
        public string? Titulo_campo { get; set; }
        public bool? Requerido { get; set; }
        public string? Tipo_campo { get; set; }

    }
}
