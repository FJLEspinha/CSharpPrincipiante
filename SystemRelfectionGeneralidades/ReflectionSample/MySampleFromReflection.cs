using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionSample
{
    [My(Count = 10)]
    public class MySampleFromReflection
    {
        public string Name { get; set; }

        public string Number { get; set; }
    }
}
