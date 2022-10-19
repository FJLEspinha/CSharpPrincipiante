using System;
using System.Collections.Generic;
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
        T[] medialist = new T[] { };
        public void Add(T media)
        {

        }
        public void PlayAll()
        {
            foreach(T media in medialist)
            {
                Console.WriteLine(media);
            }
        }
    }
}
