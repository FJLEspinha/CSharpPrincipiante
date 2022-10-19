using ClasesInterStruc;
using System;
using System.Collections; // Este es el del arraList
using System.Collections.Generic; // Este se usa para colecciones Genericas
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Genericos
{

    // Se pueden sobrecargar clases con distintos genericos
    public class PlayList<T, V,Z>
    {

    }
    
    // Indicamos que esta clase va a aceptar genericos con <T>
    // Cambiamos el generico a Song. 
    // Se aprecia cambio en el codigo con lecciones anteriores
    public class PlayList
    {
        //Anterior leccion
        // T[] medialist = new T[] { };

        // Visto en esta leccion como primer caso
        //ArrayList list = new ArrayList();

        // Colecciones genericas
        List<Song> mediaList = new List<Song>();
        public void Add(Song media)

        {
            // cambio nombres con respecto curso porque sino falla
            mediaList.Add(media);
            
        }
        public void PlayAll()
        {
            // cambio nombres con respecto curso porque sino falla
            foreach (Song media in mediaList)
            {
                Console.WriteLine(media);
            }
        }
        public void Preview()
        {
            if(mediaList.Count > 0)
            {
                // Hay que castearlo
                // T media = (T)list[0];

                // Con genericos no hay que castear
                Console.WriteLine(mediaList[0]);
            }
        }

        // Método de busqueda Con COLECCIONES
        public List<Song> SearchForCategory(string category)
        {
            // Con Linq
            // Aqui en el where entre otras nos permite el uso de funciones de alto orden.
            // Utilizaremos una lamda.
            var songs = mediaList.Where(x => x.Category == category);




            // La lambda está haciendo lo mismo que lo que está abajo a excepción del return
            /*   List<Song> songs = new List<Song>();
             *  foreach (Song song in mediaList)
              {
                  // Aquí tiene que ser exactamente igual
                  if(song.Category == category)
                  {
                      songs.Add(song);
                  }
              }*/
            // return songs;
            // Cambiamos el return porque el metodo devuelve una lista 
            // ToList() es una funcion propia de Linq que nos permite devolver la lista
            return songs.ToList();
        }

        public List<Song> SearchForTitle(string title)
        {
            // Con Linq
            var songs = mediaList.Where(x => x.Title.Contains(title));
            /*List<Song> songs = new List<Song> ();
            foreach(Song song in mediaList)
            {
                // En este método es más flexible en la búqueda
                if (song.Title.Contains(title))
                {
                    songs.Add(song);
                }
            }
            return songs;*/
            return songs.ToList();
        }

        // Linq
        public List<string> GimmeTiltlesFromSongs()
        {
            // Con Linq y Lambda
            // Con select convertimos una coleccion a otro tipo de coleccion
            var tittles = mediaList.Select(x => x.Title);
            return tittles.ToList();
            /*List<string> titles = new List<string>();
            foreach(Song song in mediaList)
            {
                titles.Add(song.Title);
            }
            return titles;*/
        }

        // Linq
        public List<string> GimmeNameOfArtists()
        {
            var namesOfArtists = mediaList.SelectMany(x => x.Artists)
                                              .Select(x =>x.Name);
            return namesOfArtists.ToList();
        }

        // Linq
        // Vamos a ver si tenemos un titulo en la lista
        public bool HaveATitle(string title)
        {
            return mediaList.Any(x => x.Title == title);
        }
    }
}
