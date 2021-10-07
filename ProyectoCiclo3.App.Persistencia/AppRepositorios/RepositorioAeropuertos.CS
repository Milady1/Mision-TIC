using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> aeropuertos;
        private readonly AppContext _appContext = new AppContext(); 

 
    public IEnumerable<Aeropuertos> GetAll()
    {
        return _appContext.Aeropuertos;
    }
 
    public Aeropuertos GetAvionWithId(int id){
        return _appContext.Aeropuertos.Find(id);
    }

    public Aeropuertos Create(Aeropuertos newAeropuerto)
    {
        var addAeropuerto = _appContext.Aeropuertos.Add(newAeropuerto);
        _appContext.SaveChanges();
        return addAeopuerto.Entity;
    }

    public void Delete(int id)
    {
    var aeropuerto = _appContext.Aeropuertos.Find(id);
    if (aeropuerto == null)
        return;
    _appContext.Aeropuertos.Remove(aeropuerto);
    _appContext.SaveChanges();
    }

    public Aeropuertos Update(Aeropuertos newAeropuerto){
        var aeropuerto = _appContext.Aeropuertos.Find(newAeropuerto.id);
        if(aeropuerto != null){
                new Aeropuertos {id=1,Nombre="Catama",Ciudad="Medellin",Pais="Colombia",Coor_x= 5,Coor_y= 8},
                new Aeropuertos {id=2,Nombre="Dorado",Ciudad="Bogota",Pais="Colombia",Coor_x= 4,Coor_y= 10},
                new Aeropuertos {id=3,Nombre="Gaitan",Ciudad="Pasto" ,Pais="Colombia",Coor_x= 4, Coor_y= 12}
            //Guardar o almacena la informacion en base de datos
            _appContext.SaveChanges();
        }
    return aeropuerto;
        }
    }
}
}

