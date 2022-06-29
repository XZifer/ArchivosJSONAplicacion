using System.Text.Json;

namespace ArchivosJSONAplicacion
{
    public class Archivosjson
    {
        public string RutaDelArchivo { get; set; }
        public string NombreDelArchivo { get; set; }
        public string jsonString { get; set; }

        public Archivosjson()
        {
            RutaDelArchivo = @"C:\Users\Luis Fernando\source\repos\XZifer\
                           Algoritmos2\ArchivosJSONAplicacion\bin\Debug\net6.0\";
            NombreDelArchivo = "favoritos.json";
        }

        //Regresa true si existe el archivo json en la ruta
        public bool ExisteArchivoDiario()
        {
            if (System.IO.File.Exists(RutaDelArchivo + NombreDelArchivo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Crea el archivo Json, y regresa true si existe, o false si no existe
        public string SerializarPeliculas(List<Pelicula> peliculas)
        {
            if (ExisteArchivoDiario())
            {
                return "El archivo ya existe";
            }
            else
            {
                Console.WriteLine("Serializando Peliculas");
                jsonString = JsonSerializer.Serialize(peliculas);
                File.WriteAllText(RutaDelArchivo + NombreDelArchivo, jsonString);
                return "Serializacion exitosa";
            }
        }
        
        //Deserializa el archivo json y lo imprime en consola
        public List<Pelicula> DeserializarPeliculas()
        {
            List<Pelicula>? peliculasEnArchivo = new List<Pelicula>();
            if (ExisteArchivoDiario())
            {
                //deserializar y regresar la lista de peliculas
                peliculasEnArchivo= JsonSerializer.Deserialize<List<Pelicula>>(jsonString);
            }
            return peliculasEnArchivo;
        }
    }
}