using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones

    {
        List<Aviones> aviones;
 
    public RepositorioAviones()
        {
            aviones= new List<Aviones>()
 {
                new Aviones {id=1,Marca="Airbus",Modelo= 2020,numero_asientos= 252, numero_baños= 5,Capacidad_maxima= 150},
                new Aviones {id=2,Marca="Boening",Modelo= 2021,numero_asientos= 238, numero_baños= 4,Capacidad_maxima= 200},
                new Aviones {id=3,Marca="ATR",Modelo= 2000,numero_asientos= 74, numero_baños= 2, Capacidad_maxima= 80}
            };
        }
 
        public IEnumerable<Aviones> GetAll() // getall significa traer todos, devueve la lista aviones.
        {
            return aviones;
        }

        public Aviones GetAvionWithId(int id) {
        // traer un avion por el identificador.
            return aviones.SingleOrDefault(b => b.id == id);
        }
    }
}
