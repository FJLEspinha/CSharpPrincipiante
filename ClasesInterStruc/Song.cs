using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInterStruc
{
    internal class Song : IMedia
    {
        public long Seconds { get; set; }

        public string Title { get; set; }

        public ShelvePosition Position { get; set; }

        public void Play()
        {
            Console.WriteLine($"Playing {Title}");
        }
    }
}
