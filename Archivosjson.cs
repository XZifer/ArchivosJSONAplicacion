using System.Text.Json;

namespace ArchivosJSONAplicacion
{
    public class Archivosjson
    {
        public string RutaDelArchivo { get; set; }
        public string NombreDelArchivo { get; set; }

        public Archivosjson()
        {
            RutaDelArchivo = @"C:\Users\Luis Fernando\source\repos\XZifer\
                           Algoritmos2\ArchivosJSONAplicacion\bin\Debug\net6.0\";
        }

        //Regresa true si existe el archivo del diario en la ruta
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
        //Crea el archivo del diario si no existe, y regresa true si existe, o false si no existe
        public string CrearArchivojson(Pelicula[] peliculas)
        {
            if (ExisteArchivoDiario())
            {
                return "El archivo ya existe";
            }
            else
            {
                Console.WriteLine("Serializando Peliculas");
                string fileName = "favoritos.json";
                string jsonString1 = JsonSerializer.Serialize(peliculas[0]);
                string jsonString2 = JsonSerializer.Serialize(peliculas[1]);
                string jsonString3 = JsonSerializer.Serialize(peliculas[2]);
                string jsonStringtotal = jsonString1 + "\n" + jsonString2 + "\n" + jsonString3;
                File.WriteAllText(fileName, jsonStringtotal);
                Console.WriteLine(File.ReadAllText(fileName));
                Console.ReadLine();
                RutaDelArchivo = System.IO.Path.Combine(RutaDelArchivo, NombreDelArchivo);
                return "Serializacion exitosa";
            }
        }
        public string EditarArchivo(string RutaDelArchivoDelDiario)
        {
            if (ExisteArchivoDiario())
            {
                string EntradaDeTexto = Console.ReadLine();
                StreamWriter sw = new StreamWriter(NombreDelArchivo);
                sw.WriteLine(EntradaDeTexto);
                sw.Close();
                return "Entrada Exitosa";
            }
            else
            {
                CrearArchivojson();
                string EntradaDeTexto = Console.ReadLine();
                StreamWriter sw = new StreamWriter(NombreDelArchivo, true);
                sw.WriteLine(EntradaDeTexto);
                sw.Close();
                return "Entrada Exitosa";

            }

        }
        public string LeerArchivo(string diarioNombre)
        {
            if (ExisteArchivoDiario())
            {
                StreamReader sr = new StreamReader(diarioNombre);
                string texto = null;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    texto += (line + "\n");
                    line = sr.ReadLine();
                }
                sr.Close();
                return texto;
            }
            else
            {
                return "UPS el Diario no se ha encointrado";
            }

        }
    }
}