using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
        private readonly AppContext _appContext = new AppContext(); 

 
    public IEnumerable<Rutas> GetAll()
    {
        return _appContext.Rutas;
    }
 
    public Rutas GetAvionWithId(int id){
        return _appContext.Rutas.Find(id);
    }

    public Rutas Create(Rutas newRutas)
    {
        var addRutas = _appContext.Rutas.Add(newRutas);
        _appContext.SaveChanges();
        return addRutas.Entity;
    }

    public void Delete(int id)
    {
    var ruta = _appContext.Rutas.Find(id);
    if (ruta == null)
        return;
    _appContext.Rutas.Remove(ruta);
    _appContext.SaveChanges();
    }

    public Rutas Update(Rutas newRuta){
        var ruta = _appContext.Rutas.Find(newRuta.id);
        if(ruta != null){
                new Rutas {id=1,Origen="Bogota",Destino= "Cali",Tiempo_estimado=16},
                new Rutas {id=2,Origen="Medellin",Destino= "Pasto",Tiempo_estimado= 24},
                new Rutas {id=3,Origen="Bogota",Destino= "Medellin",Tiempo_estimado= 8}
            };
                
            //Guardar o almacena la informacion en base de datos
            _appContext.SaveChanges();
        }
    return ruta;
        }
    }
}