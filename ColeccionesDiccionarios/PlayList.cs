using System;
using System.Collections; // Este es el del arraList
using System.Collections.Generic; // Este se usa para colecciones Genericas
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{

    // Se pueden sobrecargar clases con distintos genericos
    public class PlayList<T, V,Z>
    {

    }
    
    // Indicamos que esta clase va a aceptar genericos con <T>
    public class PlayList<T>
    {
        //Anterior leccion
        // T[] medialist = new T[] { };

        // Visto en esta leccion como primer caso
        //ArrayList list = new ArrayList();

        // Colecciones genericas
        List<T> mediaList = new List<T>();
        public void Add(T media)

        {
            // cambio nombres con respecto curso porque sino falla
            mediaList.Add(media);

        }
        public void PlayAll()
        {
            // cambio nombres con respecto curso porque sino falla
            foreach (T media in mediaList)
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
    }
}
