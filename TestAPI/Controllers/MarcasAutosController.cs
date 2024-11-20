using Microsoft.AspNetCore.Mvc;
using TestAPI.Data;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasAutosController : ControllerBase
    {
        //*************** El código abajo implementa el uso de base datos postgresql ***************//

        private readonly AppDbContext _dbContext;

        public MarcasAutosController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Get: api/MarcasAutos
        [HttpGet]
        public ActionResult GetMarcasAutos()
        {
            if (_dbContext.MarcasAutos == null)
            {
                return NotFound();
            }
            return Ok(_dbContext.MarcasAutos.ToList());
        }

        //*************** El código abajo implementa el uso de memory database ***************//
        //********************** Se creó un contexto de memory database ***************//

        /*
        private readonly MemDbContext _dbContext;

        public MarcasAutosController(MemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Get: api/MarcasAutos
        [HttpGet]
        public ActionResult GetMarcasAutos()
        {
            if (_dbContext.MarcasAutos == null)
            {
                return NotFound();
            }

            if (_dbContext.MarcasAutos.Count() == 0)
            {
                MarcasAutos marcaAuto = new MarcasAutos();
                marcaAuto.Id = 1;
                marcaAuto.Marca = "Nissan";
                _dbContext.MarcasAutos.Add(marcaAuto);
                _dbContext.SaveChanges();

                marcaAuto = new MarcasAutos();
                marcaAuto.Id = 2;
                marcaAuto.Marca = "Mitsubishi";
                _dbContext.MarcasAutos.Add(marcaAuto);
                _dbContext.SaveChanges();

                marcaAuto = new MarcasAutos();
                marcaAuto.Id = 3;
                marcaAuto.Marca = "Honda";
                _dbContext.MarcasAutos.Add(marcaAuto);
                _dbContext.SaveChanges();
            }

            return Ok(_dbContext.MarcasAutos.ToList());
        }
        */

        //*************** El código abajo no hace uso de ningún contexto ***************//
        //********************** Usado en pruebas unitarias ***************//

        /*
        public MarcasAutosController(MemDbContext dbContext)
        {
            
        }

        // Get: api/MarcasAutos
        [HttpGet]
        public ActionResult GetMarcasAutos()
        {
            List<MarcasAutos> marcas = new List<MarcasAutos>(); 

            MarcasAutos marcaAuto = new MarcasAutos();
            marcaAuto.Id = 1;
            marcaAuto.Marca = "Ford";
            marcas.Add(marcaAuto);

            marcaAuto = new MarcasAutos();
            marcaAuto.Id = 2;
            marcaAuto.Marca = "";
            marcas.Add(marcaAuto);

            marcaAuto = new MarcasAutos();
            marcaAuto.Id = 3;
            marcaAuto.Marca = "Mazda";
            marcas.Add(marcaAuto);
            
            return Ok(marcas);
        }
        */
    }
}
