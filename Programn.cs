using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArchivosJSONAplicacion
{
    public class Programn
    {
        public static void Main()
        {
            //Premio premio1 = new Premio() { Año=2000 };
            //Premio premio2 = new Premio() { Año = 2001 };
            //Premio premio3 = new Premio() { Año = 2002 };

            //Actor bruce = new Actor
            //{
            //    nombre = "Bruce Willis",
            //    fechaDeNacimiento = DateTime.Parse("1965/03/17"),
            //    premios = new List<Premio>() { premio1,premio2 }
            //};

            //Actor ben = new Actor
            //{
            //    nombre = "Ben Afflek",
            //    fechaDeNacimiento = DateTime.Parse("1972/08/15"),
            //    premios = new List<Premio>()
            //};
            //ben.premios.Add(premio3);

            //Pelicula pelicula1 = new Pelicula();
            //pelicula1.Nombre = "Armagedon";
            //pelicula1.Año = 1998;
            //pelicula1.Genero = TipoGenero.Cienciaficcion;
            //pelicula1.EsParaAdultos = true;
            //pelicula1.ListaDeActores.Add(bruce);
            //pelicula1.ListaDeActores.Add(ben);

            Pelicula pelicula1 = new Pelicula()
            {
                Nombre = "Armagedon",
                Año = 1998,
                Genero = TipoGenero.Cienciaficcion,
                EsParaAdultos = true,
                ListaDeActores = new List<Actor> {
                    new Actor(){
                        nombre="bruce",
                        fechaDeNacimiento = DateTime.Parse("1965/03/17"),
                    },
                    new Actor(){
                        nombre="ben",
                        fechaDeNacimiento = DateTime.Parse("1972/08/15"),
                    }
                }
            };

            Pelicula pelicula2 = new Pelicula()
            {
                Nombre = "Hombres de Honor",
                Año = 2000,
                Genero = TipoGenero.Drama,
                EsParaAdultos = true,
                ListaDeActores = new List<Actor> {
                    new Actor(){
                        nombre="Cuba Gooding Jr.",
                        fechaDeNacimiento = DateTime.Parse("1968/01/02"),
                    },
                    new Actor(){
                        nombre="Robert De Niro",
                        fechaDeNacimiento = DateTime.Parse("1943/08/17"),
                    }
                }
            };

            Pelicula pelicula3 = new Pelicula()
            {
                Nombre = "Duelo de Titanes",
                Año = 1998,
                Genero = TipoGenero.Drama,
                EsParaAdultos = true,
                ListaDeActores = new List<Actor> {
                    new Actor(){
                        nombre="Denzel Washington",
                        fechaDeNacimiento = DateTime.Parse("1954/12/28"),
                    },
                    new Actor(){
                        nombre="Ryan Hurst",
                        fechaDeNacimiento = DateTime.Parse("1976/06/19"),
                    }
                }
            };

            string fileName = "favoritos.json";
            string jsonString1 = JsonSerializer.Serialize(pelicula1);
            string jsonString2 = JsonSerializer.Serialize(pelicula2);
            string jsonString3 = JsonSerializer.Serialize(pelicula3);
            string jsonStringtotal = jsonString1 +"\n"+ jsonString2 +"\n"+ jsonString3;
            File.WriteAllText(fileName, jsonStringtotal);

            Console.WriteLine(File.ReadAllText(fileName));

            //Console.WriteLine("Pelicula:"+pelicula1.Nombre);
            //Console.WriteLine("Actores:");
            //foreach (Actor item in pelicula1.ListaDeActores)
            //{
            //    Console.WriteLine(item.nombre);
            //}

            //Console.WriteLine("Pelicula:" + pelicula1.Nombre);
            //Console.WriteLine("Actores:");
            //foreach (Actor item in pelicula1.ListaDeActores)
            //{
            //    Console.WriteLine(item.nombre);
            //}

        }
    }
}
