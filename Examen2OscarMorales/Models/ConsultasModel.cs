using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen2OscarMorales.Models
{
    public class ConsultasModel
    {

        Examen2Entities1 BD = new Examen2Entities1();

        public List<VentaCAsa> TraerDatos()
        {
            var result = BD.Database.SqlQuery<VentaCAsa>("EXEC traerDatos");  

            return result.ToList();
        }
        public List<VentaCAsa> Buscar(String vendedor)
        {
            if (vendedor != null){
var result = from c in BD.VentaCAsa
                         where
                         c.Vendedor.Equals(vendedor)
                         select c;

            return result.ToList();
            }
            else
            {
                var result = BD.Database.SqlQuery<VentaCAsa>("EXEC traerDatos");

                return result.ToList();
            }
            
        }
    }
}