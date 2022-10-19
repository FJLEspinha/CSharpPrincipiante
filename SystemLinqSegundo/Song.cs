using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLinqSegundo;

namespace ClasesInterStruc
{
    public class Song : Media
    {
        public long Seconds { get; set; }

       

        public ShelvePosition Position { get; set; }

        public string Category { get; set; }

        public List<Artist> Artists { get; set; }

        public override void Play()
        {
            Console.WriteLine("Increase volume");
            base.Play();
        }


    }
}
