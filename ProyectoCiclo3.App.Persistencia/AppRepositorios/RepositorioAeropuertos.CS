using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos

    {
        List<Aeropuertos> aeropuertos;
 
    public RepositorioAeropuertos()
        {
            aeropuertos= new List<Aeropuertos>()
 {
                new Aeropuertos {id=1,Nombre="Catama",Ciudad="Medellin",Pais="Colombia",Coor_x= 5,Coor_y= 8},
                new Aeropuertos {id=2,Nombre="Dorado",Ciudad="Bogota",Pais="Colombia",Coor_x= 4,Coor_y= 10},
                new Aeropuertos {id=3,Nombre="Gaitan",Ciudad="Pasto" ,Pais="Colombia",Coor_x= 4, Coor_y= 12}
            };
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
            return  aeropuertos;
        }
        public Aeropuertos GetAeropuertoWithId(int id) {
            return aeropuertos.SingleOrDefault(b => b.id == id);
        }
    }
}

