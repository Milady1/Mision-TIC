using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas

    {
        List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
 {
                new Rutas {id=1,Origen="Bogota",Destino= "Cali",Tiempo_estimado=16},
                new Rutas {id=2,Origen="Medellin",Destino= "Pasto",Tiempo_estimado= 24},
                new Rutas {id=3,Origen="Bogota",Destino= "Medellin",Tiempo_estimado= 8}
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }

        public Rutas GetRutaWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }
    }
}
