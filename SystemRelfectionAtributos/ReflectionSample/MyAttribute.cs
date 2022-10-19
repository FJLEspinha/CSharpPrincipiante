using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    // Es recomendable poner el SUFVIJO Attribute
    public class MyAttribute : Attribute
    {
        public int Count { get; set; }
    }
}
