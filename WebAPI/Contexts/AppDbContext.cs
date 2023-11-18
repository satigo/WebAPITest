using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Contexts
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Conf_EncuestaModel> Conf_Encuesta { get; set; }
        public DbSet<Camp_EncuestaModel> Camp_Encuesta { get; set; }
        /*public DbSet<Resp_Encuesta> Resp_Encuesta { get; set; }*/


    }
}
