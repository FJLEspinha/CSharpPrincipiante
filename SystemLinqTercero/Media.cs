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

        
    }
}
