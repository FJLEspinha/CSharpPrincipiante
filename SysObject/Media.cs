using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInterStruc
{
    public class Media
    {
        private int parentRate;
        public string Title { get; set; }
        public virtual void Play()
        {
            Console.WriteLine($"Playing {Title}");
        }

        protected bool ThisContentIsCorrectForThisAge(int age)
        {
            if(age >= parentRate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            // al contrario que Java vale == llamaria a Equalas
            //  return base.Equals(obj); lo que sale por defecto
            var mediaObj = (Media)obj;
            if(mediaObj.Title == this.Title)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
