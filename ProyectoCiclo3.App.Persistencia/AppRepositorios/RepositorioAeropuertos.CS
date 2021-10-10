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
        return addAeropuerto.Entity;
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
                aeropuerto.id = newAeropuerto.id;
                aeropuerto.Nombre = newAeropuerto.Nombre;
                aeropuerto.Ciudad= newAeropuerto.Ciudad;
                aeropuerto.Pais = newAeropuerto.Pais;
                aeropuerto.Coor_x = newAeropuerto.Coor_x;
                aeropuerto.Coor_y= newAeropuerto.Coor_y;
            //Guardar o almacena la informacion en base de datos
            _appContext.SaveChanges();
        }
    return aeropuerto;
        }
    }
}
    
