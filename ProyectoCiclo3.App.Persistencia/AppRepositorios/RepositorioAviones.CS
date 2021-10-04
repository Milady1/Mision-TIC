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

        
        public Aviones Create(Aviones newAvion)
        {
           if(Aviones.Count > 0){
           newAvion.id=Aviones.Max(r => r.id) +1; 
            }else{
               newAvion.id = 1; 
            }
           Aviones.Add(newAvion);
           return newAvion;
        }

          public Aviones Update(Aviones newAvion){
            var avion= aviones.SingleOrDefault(b => b.id == newAvion.id);
            if(avion != null){
                avion.Marca = newAvion.Marca;
                avion.Modelo = newAvion.Modelo;
                avion.numero_asientos = newAvion.numero_asientos;
                avion.numero_baños = newAvion.numero_baños;
                avion.Capacidad_maxima = newAvion.Capacidad_maxima;
            }
        return avion;
        }
        public void Delete(int id)
        {
        var avion= aviones.SingleOrDefault(b => b.id == id);
        aviones.Remove(avion);
        return avion;
        }


    }
}
