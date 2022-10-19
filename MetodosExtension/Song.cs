using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInterStruc
{
    public class Song : Media
    {
        public long Seconds { get; set; }

       

        public ShelvePosition Position { get; set; }

        public override void Play()
        {
            Console.WriteLine("Increase volume");
            base.Play();
        }


    }
}
