using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Controller
{
    //Controlador
    public class AveController<Ave>
    {
        public List<Ave> lista = new List<Ave>();
        public string path;
        public AveController(string ruta)
        {
            path = ruta;
        }
        //Funcion para guardar en un archivo
        public void Guardar()
        {
            string convert = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(path, convert);
        }
        //Funcion para cargar lista de Equipos
        public void Cargar()
        {
            try
            {
                string archivo = File.ReadAllText(path);
                lista = JsonConvert.DeserializeObject<List<Ave>>(archivo);
            }
            catch (Exception) { }
        }
        public void Adicionar(Ave nuevo)
        {
            lista.Add(nuevo);
            Guardar();
        }
        public List<Ave> Buscar(Func<Ave, bool> elemento)
        {
            return lista.Where(elemento).ToList();
        }
        public void Eliminar(Func<Ave, bool> elemento)
        {
            lista = lista.Where(x => !elemento(x)).ToList();
            Guardar();
        }
        public void Actualizar(Func<Ave, bool> elemento, Ave nuevo)
        {
            lista = lista.Select(x =>
            {
                if (elemento(x))
                    x = nuevo;
                return x;
            }).ToList();
            Guardar();
        }
    }
}
